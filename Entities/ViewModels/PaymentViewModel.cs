using Entities.Models;
using Entities.UtilityModels;

namespace Entities.ViewModels
{
    public class PaymentViewModel : BaseViewModel
    {
        public Payment Payment { get; set; }
        public EmployeeUser Employee { get; set; }
        public Company Company { get; set; }
        public YearToDate YearToDate { get; set; }
    }
}
