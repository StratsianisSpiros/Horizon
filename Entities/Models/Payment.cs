using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        [Display(Name = "Month")]
        public int Month { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        public string Username { get; set; }

        [Display(Name = "Work")]
        public int DaysWorked { get; set; }

        [Display(Name = "Absent")]
        public int DaysAbsent { get; set; }

        [Display(Name = "Holidays")]
        public int DaysHolidays { get; set; }

        [Display(Name = "Total Payment")]
        public decimal TotalPay { get; set; }

        [Display(Name = "Salary")]
        public decimal NormalPay { get; set; }

        [Display(Name = "Overtime")]
        public decimal OverTimePay { get; set; }

        [Display(Name = "Holiday")]
        public decimal HolidayPay { get; set; }

        [Display(Name = "Work Hours")]
        public decimal WorkHours { get; set; }

        [Display(Name = "Overtime Hours")]
        public decimal OverTimeHours { get; set; }

        [Display(Name = "Holidays Hours")]
        public decimal HolidayHours { get; set; }

        [Display(Name = "Tax Pay")]
        public decimal TaxPay { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Period")]
        public DateTime? PayDate { get; set; }
    }
}
