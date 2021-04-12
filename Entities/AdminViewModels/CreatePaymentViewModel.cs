using Entities.UtilityModels;
using Entities.Models;
using Entities.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Entities.AdminViewModels
{
    public class CreatePaymentViewModel : BaseViewModel
    {
        public Payment Payment { get; set; }

        public EmployeeUser Employee { get; set; }

        [Display(Name ="Month")]
        public int[] Month { get => MonthYearArrays.Month; }

        [Display(Name = "Year")]
        public int[] Year { get => MonthYearArrays.Year; }
    }
}
