using Entities.Models;
using Entities.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class EmployeeRequestController : BaseEmployeeController
    {
        // GET: Request
        public async Task<ActionResult> Index(string message, int? startIndex)
        {
            int currentIndex = startIndex ?? 0;
            int currentPage = 5;

            var user = await _employeeRepository.GetEmployeeWithRequestsAsync(CurrentUser);

            var request = user.Requests.OrderByDescending(r => r.RequestDate.Value.Day).ToList() ?? new List<Request>();
    
            var page = request.Skip(currentIndex).Take(currentPage);

            RequestViewModel model = new RequestViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

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
                Username = CurrentUser,
                RequestDate = DateTime.Today,
                Content = e.Content
            };

            if (ModelState.IsValid)
            {
                status = await _employeeRepository.CreateEmployeeRequestAsync(req);

            }

            return new JsonResult { Data = new { status = status } };
        }
    }
}