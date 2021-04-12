using Entities.Models;
using Entities.ViewModels;

namespace Entities.EmployeeViewModels
{
    public class EmployeeIndexViewModel : BaseViewModel
    {
        public EmployeeUser Employee { get; set; }
        public EmployeeEvent Today { get; set; }
        public EmployeeEvent Tomorrow { get; set; }
        public decimal TotalPay { get; set; }
    }
}
