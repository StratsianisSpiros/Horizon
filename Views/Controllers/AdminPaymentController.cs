using Entities.AdminViewModels;
using Entities.EmployeeViewModels;
using Entities.Models;
using Repositories.Services;
using Strategy.PaymentStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class AdminPaymentController : BaseAdminController
    {
        //GET: Payment
        public async Task<ActionResult> Index(string username, string message, int? paymentsYear)
        {
            int filteredYear = paymentsYear ?? DateTime.Now.Year;
            var user = await _employeeRepository.GetEmployeeWithPaymentsAsync(username) ?? new EmployeeUser() { Payments = new List<Payment>() };
            var years = user.Payments.Select(p => p.Year).Distinct();
            var filteredPayments = user.Payments.Where(p => p.Year == filteredYear);
            Payment[] payments = YearPaymentsService.YearPaymentsByMonth(filteredPayments);

            EmloyeePaymentsViewModel payment = new EmloyeePaymentsViewModel
            {
                LoggedUser = CurrentUser, //BaseViewModel
                LoggedCompany = CurrentCompany, //BaseViewModel
                Message = message, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Year = years.ToList(),
                PaymentsYear = filteredYear,
                Payments = payments,
                Employee = user
            };

            return View(payment);
        }

        public async Task<ActionResult> CreateUpdate(string username, int month, int year, string paymentId)
        {
            int currentPaymentid = int.TryParse(paymentId, out int p) ? p : 0;
            var user = await _employeeRepository.GetEmployeePaymentEventsAsync(username);

            PaymentStrategy strategy = new PaymentStrategy();
            strategy.SetPaymentStrategy(user.PayMethod);
            var payment = strategy.MakePayment(user, month, year);
            payment.PaymentId = currentPaymentid;

            CreatePaymentViewModel model = new CreatePaymentViewModel()
            {
                LoggedUser = CurrentUser, //BaseViewModel
                LoggedCompany = CurrentCompany, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Employee = user,
                Payment = payment
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateUpdate(string username, Payment payment)
        {
            if (ModelState.IsValid)
            {
                await _employeeRepository.CreateUpdateEmployeePaymentAsyc(username, payment);

                return RedirectToAction("Index", new { username, message = "Payment updated successfully" });
            }

            return RedirectToAction("Index", new { username, message = "Something went wrong." });
        }
    }
}