using Entities.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Entities.AdminViewModels
{
    public class AdminUpdateViewModel : BaseViewModel
    {
        [Display(Name = "First Name")]
        [RegularExpression("^[A-Z][A-Za-z]+$", ErrorMessage = "Name must contain only letters and start with Capital")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [RegularExpression("^[A-Z][A-Za-z]+$", ErrorMessage = "Name must contain only letters and start with Capital")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Phone number need 10 digits")]
        public string PhoneNumber { get; set; }
    }
}
