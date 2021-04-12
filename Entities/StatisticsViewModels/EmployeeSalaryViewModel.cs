
namespace Entities.StatisticsViewModels
{
    public class EmployeeSalaryViewModel
    {
        public decimal[] TotalPay { get; set; }
        public decimal[] OvertimePay { get; set; }
        public decimal[] NormalPay { get; set; }
        public string[] MonthNames { get; set; }
    }
}
