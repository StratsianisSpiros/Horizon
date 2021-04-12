using Entities.Models;
using Entities.UtilityModels;
using Strategy.Extensions;
using Strategy.Interfaces;
using System;
using System.Linq;

namespace Strategy.PaymentStrategy
{
    //Strategy option to calculate employee with yearly payment Work Status
    internal class YearPayment : IPayment
    {
        public Payment MakePayment(EmployeeUser user, int month, int year)
        {
            var events = user.EmployeeEvent.Where(e => e.Start.Value.Month == month
                                                && e.Start.Value.Year == year);

            var hoursWorked = events.Where(e => e.Status == WorkStatus.Work).Select(e => e.CalculateWorkHours()).Sum();
            var paydate = events.Min(e => e.Start) ?? new DateTime();

            if (paydate == DateTime.MinValue)
                paydate = DateTime.Now;

            Payment payment = new Payment
            {
                Month = month,
                Year = year,
                PayDate = paydate,
                WorkHours = hoursWorked,
                DaysWorked = events.Where(e => e.Status == WorkStatus.Work).Count(),
                OverTimeHours = (decimal)events.Where(e => e.Status == WorkStatus.Work).Sum(e => e.Overtime),
                DaysAbsent = events.Where(e => e.Status == WorkStatus.Absent).Count(),
                DaysHolidays = events.Where(e => e.Status == WorkStatus.Holiday).Count(),
                Username = user.UserName
            };

            payment.HolidayHours = payment.DaysHolidays * 8;
            payment.OverTimePay = Math.Round(payment.OverTimeHours * user.OverTimeRate);
            payment.NormalPay = Math.Round(user.PayRate / 12, 2);
            payment.HolidayPay = Math.Round(payment.HolidayHours * user.PayRate / 12 / 22 / 8, 2);
            payment.TotalPay = Math.Round(payment.OverTimePay + payment.NormalPay + payment.HolidayPay, 2);
            payment.TaxPay = Math.Round(payment.TotalPay * user.TaxRate / 100, 2);
           
            return payment;
        }
    }
}
