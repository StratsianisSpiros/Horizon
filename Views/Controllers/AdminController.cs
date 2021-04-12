using Entities.AdminViewModels;
using Entities.Models;
using Entities.UtilityModels;
using Microsoft.AspNet.Identity;
using Repositories.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class AdminController : BaseAdminController
    {
        //Admin index show all Company's Employees
        public ActionResult Index(string search, string message, int? startIndex)
        {
            var employeeUsers = EmployeeManager.Users.Where(u => u.CompanyId == CurrentCompanyId);

            int currentIndex = startIndex ?? 0;
            int currentPage = 6;

            if (!string.IsNullOrEmpty(search))
                employeeUsers = employeeUsers.Where(u => u.LastName.Contains(search) || u.FirstName.Contains(search));

            employeeUsers = employeeUsers.OrderBy(u => u.UserName);

            var page = employeeUsers.Skip(currentIndex).Take(currentPage);

            AdminIndexViewModel model = new AdminIndexViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
                Message = message, //BaseViewModel

                Search = search, //Paged
                CurrentIndex = currentIndex, //Paged
                CurrentPage = currentPage, //Paged
                MaxIndex = employeeUsers.Count(), //Paged

                Employees = page.ToList()
            };

            return View(model);
        }
        
        
        public ActionResult CreateEmployee(string username)
        {
            if (username == null)
            {
                EmployeeRegisterViewModel model = new EmployeeRegisterViewModel
                {
                    LoggedUser = CurrentUser, //BaseViewModel
                    LoggedCompany = CurrentCompany, //BaseViewModel
                    LogoUrl = CurrentLogoUrl, //BaseViewModel
                    
                    HireDate = DateTime.Today
                };

                return View(model);
            }

            var user = EmployeeManager.Users.FirstOrDefault(u => u.UserName == username);

            EmployeeUpdateModel employee = new EmployeeUpdateModel
            {
                LoggedUser =  CurrentUser,  //BaseViewModel
                LoggedCompany = CurrentCompany,  //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Payrate = user.PayRate,
                OvertimeRate = user.OverTimeRate,
                Phone = user.PhoneNumber,
                Address = user.Address,
                TaxRate = user.TaxRate,
                PayMethod = user.PayMethod,
                PayMethods = new List<PayMethod>() { PayMethod.Hour, PayMethod.Day, PayMethod.Month, PayMethod.Year }
        };

            return View("UpdateEmployee", employee);
        }

        //Creates an Employee for the Company
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateEmployee(EmployeeRegisterViewModel model)
        {
            string upgraded = await _adminRepository.GetUserStatusAsync(CurrentUser) ?? "";
            int numberOfEmployees = EmployeeManager.Users.Where(u => u.CompanyId == CurrentCompanyId).Count();

            if(numberOfEmployees >= 5 && !upgraded.Equals("active"))
                return RedirectToAction("Index", "Admin", new { message = "Please upgrade your account to add more employees." });

            if (ModelState.IsValid)
            {
                var user = new EmployeeUser
                {
                    UserName = model.Username,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PayRate = model.Payrate,
                    OverTimeRate = model.OvertimeRate,
                    TaxRate = model.TaxRate,
                    HireDate = model.HireDate,
                    PhoneNumber = model.Phone,
                    Address = model.Address,
                    PayMethod = model.PayMethod,

                    CompanyId = CurrentCompanyId,
                    CompanyName = CurrentCompany,
                    IsAdmin = false
                };

                var result = await EmployeeManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                    result = await EmployeeManager.AddToRoleAsync(user.Id, "Employee");

                if (result.Succeeded)
                    return RedirectToAction("Index", "Admin", new { message = "Employee created successfully." });

                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //Creates an Employee for the Company
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UpdateEmployee(EmployeeUpdateModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await EmployeeManager.Users.FirstOrDefaultAsync(u => u.UserName == model.Username);

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PayRate = model.Payrate;
                user.OverTimeRate = model.OvertimeRate;
                user.TaxRate = model.TaxRate;
                user.PayMethod = model.PayMethod;
                user.PhoneNumber = model.Phone;
                user.Address = model.Address;

                var result = await EmployeeManager.UpdateAsync(user);

                if (result.Succeeded)
                    return RedirectToAction("Index", "Admin", new { message = "Employee updated successfully."});

                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
        
        public async Task<ActionResult> DeleteEmployee(string username)
        {
            if (username == null) 
                return View("Index");

            var result = await _employeeRepository.DeleteEmployeeAsync(username);

            return new JsonResult { Data = new { status = result } };
        }

        public ActionResult EmployeeChangePassword(string username)
        {
            EmployeeChangePasswordViewModel employee = new EmployeeChangePasswordViewModel
            {
                LoggedUser = CurrentUser,  //BaseViewModel
                LoggedCompany = CurrentCompany,  //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Username = username
            };

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EmployeeChangePassword(EmployeeChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await EmployeeManager.Users.FirstOrDefaultAsync(u => u.UserName == model.Username);
                var token = await EmployeeManager.GeneratePasswordResetTokenAsync(user.Id);
                var result = await EmployeeManager.ResetPasswordAsync(user.Id, token, model.Password);

                if (result == IdentityResult.Success)
                    return RedirectToAction("Index", "Admin", new { message = "Employee password updated successfully." });
            }

            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

    }
}