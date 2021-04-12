using Entities.AdminViewModels;
using Entities.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class AdminDetailsController : BaseAdminController
    {
        // GET: AdminDetails
        public async Task<ActionResult> Index(string message)
        {

            var user = await _adminRepository.GetUserAsync(CurrentUser);
            var company = await _companyRepository.GetCompanyWithPostsAsync(CurrentCompanyId);

            AdminDetailsViewModel model = new AdminDetailsViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                Message = message, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Company = company,
                AdminUser = user
            };

            return View(model);
        }

        public async Task<ActionResult> UpdateUser()
        {
            var user = await _adminRepository.GetUserAsync(CurrentUser);

            AdminUpdateViewModel model = new AdminUpdateViewModel
            {
                LoggedUser = CurrentUser, //BaseViewModel
                LoggedCompany = CurrentCompany, //BaseViewModel
                LogoUrl = CurrentLogoUrl,

                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UpdateUser(AdminUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _adminRepository.GetUserAsync(CurrentUser);

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PhoneNumber = model.PhoneNumber;

                await _adminRepository.UpdateUserAsync(user);

                return RedirectToAction("Index", "AdminDetails", new { message = "User details updated successfully." });
            }

            return RedirectToAction("Index", "AdminDetails", new { message = "Something went wrong!" });
        }

        public async Task<ActionResult> UpdateCompany(string message)
        {
            var company = await _companyRepository.GetCompanyWithPostsAsync(CurrentCompanyId);

            CompanyUpdateViewModel model = new CompanyUpdateViewModel
            {
                LoggedUser = CurrentUser, //BaseViewModel
                LoggedCompany = CurrentCompany, //BaseViewModel
                Message = message, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                CompanyName = company.CompanyName,
                CompanyAddress = company.CompanyAddress,
                CompanyPhone = company.CompanyPhone
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UpdateCompany(Company model)
        {
            if (ModelState.IsValid)
            {
                var company = await _companyRepository.GetCompanyWithPostsAsync(CurrentCompanyId);

                if (!CurrentCompany.Equals(model.CompanyName))
                {
                    var user = await _adminRepository.GetUserAsync(CurrentUser);
                    user.CompanyName = model.CompanyName;
                    await _adminRepository.UpdateUserAsync(user);

                    company.CompanyName = model.CompanyName;

                    var result = await _employeeRepository.UpdateAllEmployeesCompanyAsync(company, CurrentCompanyId);

                }

                company.CompanyAddress = model.CompanyAddress;
                company.CompanyPhone = model.CompanyPhone;

                await _companyRepository.UpdateCompanyAsync(company);

                return RedirectToAction("Index", "AdminDetails", new { message = "Company details updated successfully."});
            }

            return RedirectToAction("Index", "AdminDetails", new { message = "Something went wrong!" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UploadFiles(CompanyUpdateViewModel model)
        {
            var company = await _companyRepository.GetCompanyWithPostsAsync(CurrentCompanyId);
            string fileCurrentPath = Server.MapPath(company.LogoUrl);

            if (ModelState.IsValid)
            {
                string pic = Path.GetFileName(model.UploadFile.FileName);
                string path = Path.Combine(Server.MapPath("~/CompanyLogo"), CurrentCompanyId + pic);
                string dbPath = Url.Content("~/CompanyLogo/" + CurrentCompanyId + pic);

                company.LogoUrl = dbPath;

                bool result = await _companyRepository.UpdateCompanyAsync(company);

                if (result)
                {
                    if (System.IO.File.Exists(fileCurrentPath))
                            System.IO.File.Delete(fileCurrentPath);

                    model.UploadFile.SaveAs(path);
                }

                return RedirectToAction("Index", "AdminDetails", new { message = "File uploaded successfully" });
            }

            //Adds model state errors to a string
            string errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage)).Aggregate((a, b) => a + Environment.NewLine + b);

            return RedirectToAction("UpdateCompany", "AdminDetails", new { message = errors });
        }
    }
}