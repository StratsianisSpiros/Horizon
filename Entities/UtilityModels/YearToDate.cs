using System.ComponentModel.DataAnnotations;

namespace Entities.UtilityModels
{
    public class YearToDate
    {
        [Display(Name = "Total Normal Payment to date")]
        public decimal NormalPayYTD { get; set; }

        [Display(Name = "Total Overtime Payment to date")]
        public decimal OverTimePayYTD { get; set; }

        [Display(Name = "Total Holiday Payment to date")]
        public decimal HolidayPayYTD { get; set; }

        [Display(Name = "Total Payment to date")]
        public decimal TotalPayYTD { get; set; }

        [Display(Name = "Tax Pay to date")]
        public decimal TaxPayYTD { get; set; }
    }
}
