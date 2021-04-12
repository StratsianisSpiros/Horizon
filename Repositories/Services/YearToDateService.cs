using Entities.UtilityModels;
using Repositories.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Services
{
    public class YearToDateService
    {
        private readonly EmployeeRepository _employeeRepository;

        public YearToDateService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<YearToDate> CalculateYearToDate(string username, int endMonth)
        {
            var user = await _employeeRepository.GetEmployeeWithPaymentsAsync(username);
            var payments = user.Payments.Where(p => p.Month <= endMonth);

            YearToDate YTD = new YearToDate()
            {
                NormalPayYTD = payments.Sum(p => p.NormalPay),
                OverTimePayYTD = payments.Sum(p => p.OverTimePay),
                HolidayPayYTD = payments.Sum(p => p.HolidayPay),
                TaxPayYTD = payments.Sum(p => p.TaxPay),
                TotalPayYTD = payments.Sum(p => p.TotalPay)
            };

            return YTD;
        }
    }
}
