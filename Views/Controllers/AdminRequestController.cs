using Entities.Models;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class AdminRequestController : BaseAdminController
    {
        // GET: AdminRequest
        public async Task<ActionResult> Index(string message, int? startIndex)
        {
            int currentIndex = startIndex ?? 0;
            int currentPage = 7;

            var employees = await _employeeRepository.GetEmployeesWithRequestsAsync(CurrentCompanyId);
            var request = employees.SelectMany(x => x.Requests).OrderByDescending(r => r.RequestDate);

            var page = request.Skip(currentIndex).Take(currentPage);

            RequestViewModel model = new RequestViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentCompany, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
                Message = message, //BaseViewModel

                CurrentIndex = currentIndex, //Paged
                CurrentPage = currentPage, //Paged
                MaxIndex = request.Count(), //Paged

                Requests = page
            };

            return View(model);
        }

        [HttpPost]
        public async Task<JsonResult> Submit(Request e)
        {            
            var status = false;
            IFormatProvider culture = new CultureInfo("en-US", true);

            Request req = new Request()
            {
                Username = e.Username,
                RequestId = e.RequestId,
                AskRequest = e.AskRequest,
                Response = e.Response,
            };

            

            if (ModelState.IsValid)
            {
                status = await _employeeRepository.CreateEmployeeResponseRequestAsync(req);

            }

            return new JsonResult { Data = new { status = status } };
        }
    }
}
