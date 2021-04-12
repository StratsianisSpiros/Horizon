using Entities.EmployeeViewModels;
using Entities.Models;
using Entities.ViewModels;
using Repositories.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class EmployeePaymentController : BaseEmployeeController
    {
        // GET: EmployeePayment
        public async Task<ActionResult> Index(int? paymentsYear)
        {
            int filteredYear = paymentsYear ?? DateTime.Now.Year;
            var user = await _employeeRepository.GetEmployeeWithPaymentsAsync(CurrentUser) ?? new EmployeeUser() { Payments = new List<Payment>() };
            var years = user.Payments.Select(p => p.Year).Distinct();
            var filteredPayments = user.Payments.Where(p => p.Year == filteredYear);
            Payment[] payments = YearPaymentsService.YearPaymentsByMonth(filteredPayments);

            EmloyeePaymentsViewModel model = new EmloyeePaymentsViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                PaymentsYear = filteredYear,
                Year = years.ToList(),
                Payments = payments,
                Employee = user,
                MonthNames = CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat.MonthNames
            };

            return View(model);
        }


        public async Task<ActionResult> ViewPayment(int paymentId) 
        {
            var user = await _employeeRepository.GetEmployeeWithPaymentsAsync(CurrentUser);
            var payment = user.Payments.FirstOrDefault(p => p.PaymentId == paymentId);
            var company = _companyRepository.GetCompany(CurrentCompanyId);
            var yearToDate = await new YearToDateService(_employeeRepository).CalculateYearToDate(CurrentUser, payment.Month);

            PaymentViewModel model = new PaymentViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
                 
                Company = company,
                Employee = user,
                Payment = payment,
                YearToDate = yearToDate             
            };

            return View(model);
        }
    }
}