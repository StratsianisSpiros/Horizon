using Entities.Models;
using System.Collections.Generic;

namespace Entities.StatisticsViewModels
{
    public class MonthlyPaymentViewModel
    {
        public List<string> EmployeesNames { get; set; }
        public List<Payment> EmployeesSalary { get; set; }
    }
}


