using System.Collections.Generic;

namespace Entities.StatisticsViewModels
{
    public class CompanyEmployeesSalaryViewModel
    {
        public List<string> EmployeesNames { get; set; }
        public List<decimal> EmployeesPayRate { get; set; }
        public List<decimal> EmployeesOvertimeRate { get; set; }
    }
}
