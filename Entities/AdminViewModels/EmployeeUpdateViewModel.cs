using Entities.UtilityModels;
using Entities.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.AdminViewModels
{
    public class EmployeeUpdateModel : BaseViewModel
    {
        public string Username { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Maximum characters allowed is 20")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[A-Z][A-Za-z\s]+$", ErrorMessage = "Name must start with capital and consist only from letters and whitespace")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Maximum characters allowed is 20")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z][A-Za-z\s]+$", ErrorMessage = "Last Name must start with capital and consist only from letters and whitespace")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Phone number need 10 digits")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [StringLength(50, ErrorMessage = "Maximum characters allowed is 50")]
        public string Address { get; set; }

        [Display(Name = "Pay Rate")]
        [DataType(DataType.Currency, ErrorMessage = "Pay Rate should be a valid number.")]
        public decimal Payrate { get; set; }

        [Display(Name = "Overtime Pay Rate")]
        [DataType(DataType.Currency, ErrorMessage = "Overtime Pay Rate should be a valid number.")]
        public decimal OvertimeRate { get; set; }

        [Display(Name = "Select employee payment option")]
        public PayMethod PayMethod { get; set; }

        [Display(Name = "Tax Rate")]
        public int TaxRate { get; set; }

        public List<PayMethod> PayMethods { get; set; } 
    }
}
