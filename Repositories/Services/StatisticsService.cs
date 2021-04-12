using Entities.Models;
using Entities.StatisticsViewModels;
using Entities.UtilityModels;
using Repositories.Repository;
using Strategy.PaymentStrategy;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Services
{
    public class StatisticsService
    {
        private readonly EmployeeRepository _employeeRepository;

        public StatisticsService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Calculates company monthly payment based on month and year to be used in statistics view
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns><see cref="MonthlyPaymentViewModel"/></returns>
        public async Task<MonthlyPaymentViewModel> MonthlyPayment(int companyId, int month, int year)
        {
            var employees = await _employeeRepository.GetEmployeesWithEventsAsync(companyId);

            List<Payment> payments = new List<Payment>();
            PaymentStrategy strategy = new PaymentStrategy();

            foreach (var e in employees)
            {
                strategy.SetPaymentStrategy(e.PayMethod);
                payments.Add(strategy.MakePayment(e, month, year));
            }

            MonthlyPaymentViewModel model = new MonthlyPaymentViewModel
            {
                EmployeesNames = employees.Select(e => e.FullName).ToList(),
                EmployeesSalary = payments ?? new List<Payment>()
            };

            return model;
        }

        /// <summary>
        /// Calculates company yearly payment to be used in statistics view
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns><see cref="YearPaymentsViewModel"/></returns>
        public async Task<YearPaymentsViewModel> YearPayments(int companyId)
        {
            var users = await _employeeRepository.GetEmployeesWithPaymentsAsync(companyId);
            var paymentsByMonth = users.SelectMany(p => p.Payments).GroupBy(p => p.Month).OrderBy(p => p.Key);
            var totalPayments = new List<decimal>();
            var overtimePayments = new List<decimal>();
            var normalPayments = new List<decimal>();

            foreach (var item in paymentsByMonth)
            {
                totalPayments.Add(item.Sum(p => p.TotalPay));
                overtimePayments.Add(item.Sum(p => p.OverTimePay));
                normalPayments.Add(item.Sum(p => p.NormalPay));
            }

            YearPaymentsViewModel model = new YearPaymentsViewModel
            {
                YearNormalPayments = totalPayments,
                YearOverTimePayments = overtimePayments,
                YearTotalPayments = totalPayments,
                MonthNames = CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat.MonthNames
            };

            return model;
        }

        /// <summary>
        /// Calculates employee salary by month for the given employee to be used in statistics view
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="EmployeeSalaryViewModel"/></returns>
        public async Task<EmployeeSalaryViewModel> EmployeeSalary(string username)
        {
            var user = await _employeeRepository.GetEmployeeWithPaymentsAsync(username);
            var payments = user.Payments.Where(p => p.Year == DateTime.Now.Year).OrderBy(p => p.Month);

            EmployeeSalaryViewModel model = new EmployeeSalaryViewModel
            {
                TotalPay = payments.Select(p => p.TotalPay).ToArray(),
                OvertimePay = payments.Select(p => p.OverTimePay).ToArray(),
                NormalPay = payments.Select(p => p.NormalPay).ToArray(),
                MonthNames = CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat.MonthNames
            };

            return model;
        }

        /// <summary>
        /// Calculates employee attendance for the given employee and month to be used in statistics view
        /// </summary>
        /// <param name="username"></param>
        /// <param name="month"></param>
        /// <returns><see cref="EmployeeAttendanceViewModel"/></returns>
        public async Task<EmployeeAttendanceViewModel> EmployeeAttendance(string username, int month)
        {
            var user = await _employeeRepository.GetEmployeeWithEventsAsync(username);
            var events = user.EmployeeEvent.Where(e => e.Start.Value.Month == month && e.Start.Value.Year == DateTime.Now.Year);

            EmployeeAttendanceViewModel model = new EmployeeAttendanceViewModel
            {
                WorkDays = events.Where(e => e.Status == WorkStatus.Work).Count(),
                AbsentDays = events.Where(e => e.Status == WorkStatus.Absent).Count(),
                Holidays = events.Where(e => e.Status == WorkStatus.Holiday).Count(),
                Months = MonthYearArrays.Month,
                Month = CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat.GetMonthName(month)
            };

            return model;
        }

        /// <summary>
        /// Calculates company employees salary on an hourly basis to be used in statistics view
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns><see cref="CompanyEmployeesSalaryViewModel"/></returns>
        public async Task<CompanyEmployeesSalaryViewModel> CompanyEmployeesSalaries(int companyId)
        {
            var employees = await _employeeRepository.GetEmployeesAsync(companyId);

            List<decimal> employeesPayrate = new List<decimal>();

            foreach (var employee in employees)
            {
                switch (employee.PayMethod)
                {
                    case PayMethod.Hour:
                        employeesPayrate.Add(Math.Round(employee.PayRate, 2));
                        break;
                    case PayMethod.Day:
                        employeesPayrate.Add(Math.Round(employee.PayRate / 8, 2));
                        break;
                    case PayMethod.Month:
                        employeesPayrate.Add(Math.Round(employee.PayRate / 22 / 8, 2));
                        break;
                    case PayMethod.Year:
                        employeesPayrate.Add(Math.Round(employee.PayRate / 12 / 22 / 8, 2));
                        break;
                    default:
                        employeesPayrate.Add(employee.PayRate / 8);
                        break;
                }
            }

            CompanyEmployeesSalaryViewModel model = new CompanyEmployeesSalaryViewModel
            {
                EmployeesNames = employees.Select(e => e.FirstName + " " + e.LastName).ToList(),
                EmployeesPayRate = employeesPayrate,
                EmployeesOvertimeRate = employees.Select(e => e.OverTimeRate).ToList(),
            };

            return model;
        }

        /// <summary>
        /// Calculates company employees attendance based on month to be used in statistics view
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="month"></param>
        /// <returns><see cref="CompanyAttendanceViewModel"/></returns>
        public async Task<CompanyAttendanceViewModel> CompanyAttendance(int companyId, int month)
        {
            var employees = await _employeeRepository.GetEmployeesWithEventsAsync(companyId);
            var monthlyEvents = employees.SelectMany(e => e.EmployeeEvent).GroupBy(e => e.Username);

            List<int> totalWorkDays = new List<int>();
            List<int> totalAbsentDays = new List<int>();
            List<int> totalHolidays = new List<int>();

            foreach (var item in monthlyEvents)
            {
                totalWorkDays.Add(item.Where(e => e.Status == WorkStatus.Work && e.Start.Value.Month == month).Count());
                totalAbsentDays.Add(item.Where(e => e.Status == WorkStatus.Absent && e.Start.Value.Month == month).Count());
                totalHolidays.Add(item.Where(e => e.Status == WorkStatus.Holiday && e.Start.Value.Month == month).Count());
            }

            CompanyAttendanceViewModel model = new CompanyAttendanceViewModel
            {
                EmployeeNames = employees.Select(e => e.FirstName + " " + e.LastName).ToList(),
                TotalWorkDays = totalWorkDays,
                TotalAbsentDays = totalAbsentDays,
                TotalHolidays = totalHolidays
            };

            return model;
        }
    }
}
