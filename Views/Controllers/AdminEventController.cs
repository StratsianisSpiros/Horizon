using Entities.AdminViewModels;
using Entities.EmployeeViewModels;
using Entities.UtilityModels;
using Entities.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;
using System.Collections.Generic;

namespace Views.Controllers
{
    public class AdminEventController : BaseAdminController
    {
        // GET: Event
        public ActionResult Index(string message)
        {
            var employeeUsers = EmployeeManager.Users.Where(u => u.CompanyId == CurrentCompanyId).ToList() ?? new List<EmployeeUser>();

            AdminIndexViewModel model = new AdminIndexViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                Message = message, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Employees = employeeUsers
            };
            return View(model);
        }

        public async Task<JsonResult> GetEvents()
        {
            var events = await _companyRepository.GetCompanyEventsAsync(CurrentCompanyId);

            return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public async Task<JsonResult> SaveEvent(EmployeeEventViewModel e)
        {
            var status = false;
            IFormatProvider culture = new CultureInfo("en-US", true);

            EmployeeEvent eve = new EmployeeEvent()
            {
                CompanyID = CurrentCompanyId,
                Username = e.Username,
                Overtime = e.Overtime ?? 0,
                Start = DateTime.ParseExact(e.Start, "dd/MM/yyyy HH:mm tt", culture),
                End = DateTime.ParseExact(e.End, "dd/MM/yyyy HH:mm tt", culture),
                Description = e.Description ?? "No description",
                Color = e.Color,
                Status = StatusColor.MapColorToStatus(e.Color),
                IsFullDay = e.IsFullDay,
                EventID = e.EventID
            };

            if (ModelState.IsValid)
            {
                status = await _employeeRepository.CreateEmployeeEventAsync(eve);
            }

            return new JsonResult { Data = new { status = status } };
        }

        [HttpPost]
        public async Task<JsonResult> DeleteEvent(int eventID)
        {
            await _employeeRepository.DeleteEmployeeEventAsync(eventID);

            return new JsonResult { Data = new { status = true } };
        }
    }
}