using Entities.EmployeeViewModels;
using Strategy.PaymentStrategy;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class EmployeeController : BaseEmployeeController
    {
        // GET: Employee
        public async Task<ActionResult> Index()
        {
            var employee = await _employeeRepository.GetEmployeeWithEventsAsync(CurrentUser);
            var todayEvent = await _employeeRepository.GetEmployeeEventByDayAsync(CurrentUser, DateTime.Now.Day, DateTime.Now.Month);
            var tomorrowEvent = await _employeeRepository.GetEmployeeEventByDayAsync(CurrentUser, DateTime.Now.Day + 1, DateTime.Now.Month);

            var strategy = new PaymentStrategy();
            strategy.SetPaymentStrategy(employee.PayMethod);
            var payment = strategy.MakePayment(employee, DateTime.Now.Month, DateTime.Now.Year);

            EmployeeIndexViewModel model = new EmployeeIndexViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Employee = employee,
                Today = todayEvent,
                Tomorrow = tomorrowEvent,
                TotalPay = payment.TotalPay,
            };

            return View(model);
        }
    }
}