using Entities.AdminViewModels;
using Repositories.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class AdminStatisticsController : BaseAdminController
    {
        // GET: Statistics
        public ActionResult Index(string message)
        {
            AdminStatisticsViewModel model = new AdminStatisticsViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
                Message = message, //BaseViewModel
            };

            return View(model);
        }

        public ActionResult CompanyStatistics(string message)
        {
            AdminStatisticsViewModel model = new AdminStatisticsViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
                Message = message, //BaseViewModel
            };

            return View(model);
        }

        public async Task<ActionResult> EmployeeStatistics(string message)
        {
            var employees = await _employeeRepository.GetEmployeesAsync(CurrentCompanyId);

            AdminStatisticsViewModel model = new AdminStatisticsViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
                Message = message, //BaseViewModel

                EmployeeNames = employees.ToList()
            };

            return View(model);
        }

        public async Task<JsonResult> MonthlyPayment(string month, string year)
        {
            int currentMonth = int.TryParse(month, out int result) ? result : DateTime.Now.Month;
            int currentYear = int.TryParse(year, out result) ? result : DateTime.Now.Year;

            StatisticsService statistics = new StatisticsService(_employeeRepository);
            var model = await statistics.MonthlyPayment(CurrentCompanyId, currentMonth, currentYear);

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> CurrentYearPayments()
        {
            StatisticsService statistics = new StatisticsService(_employeeRepository);
            var model = await statistics.YearPayments(CurrentCompanyId);

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> EmployeeSalary(string username)
        {
            StatisticsService statistics = new StatisticsService(_employeeRepository);
            var model = await statistics.EmployeeSalary(username);

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> EmployeeAttendance(string username, string month)
        {
            int currentMonth = int.TryParse(month, out int result) ? result : DateTime.Now.Month;

            StatisticsService statistics = new StatisticsService(_employeeRepository);
            var model = await statistics.EmployeeAttendance(username, currentMonth);

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> CompanyEmployeesSalaries()
        {
            StatisticsService statistics = new StatisticsService(_employeeRepository);
            var model = await statistics.CompanyEmployeesSalaries(CurrentCompanyId);

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> CompanyAttendance(string month)
        {
            int currentMonth = int.TryParse(month, out int result) ? result : DateTime.Now.Month;

            StatisticsService statistics = new StatisticsService(_employeeRepository);
            var model = await statistics.CompanyAttendance(CurrentCompanyId, currentMonth);

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}