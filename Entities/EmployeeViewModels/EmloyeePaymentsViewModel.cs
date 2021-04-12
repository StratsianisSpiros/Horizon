using Entities.Models;
using Entities.ViewModels;
using System.Collections.Generic;

namespace Entities.EmployeeViewModels
{
    public class EmloyeePaymentsViewModel : BaseViewModel
    {
        public Payment[] Payments { get; set; }
        public EmployeeUser Employee { get; set; }
        public string[] MonthNames { get; set; }
        public ICollection<int> Year { get; set; }
        public int PaymentsYear { get; set; }
    }
}
