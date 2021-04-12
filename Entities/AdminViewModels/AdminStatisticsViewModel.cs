using Entities.Models;
using Entities.UtilityModels;
using Entities.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.AdminViewModels
{
    public class AdminStatisticsViewModel : BaseViewModel
    {
        [Display(Name = "Month")]
        public int[] Month { get => MonthYearArrays.Month; }

        [Display(Name = "Year")]
        public int[] Year { get => MonthYearArrays.Year; }

        [Display(Name = "Employee")]
        public List<EmployeeUser> EmployeeNames { get; set; }
    }
}
