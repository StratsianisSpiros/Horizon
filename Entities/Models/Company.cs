using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        [Display(Name = "Company")]
        [StringLength(20, ErrorMessage = "Maximum characters allowed is 20")]
        public string CompanyName { get; set; }

        [Display(Name = "Address")]
        [StringLength(50, ErrorMessage = "Maximum characters allowed is 50")]
        public string CompanyAddress { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Phone number need 10 digits")]
        public string CompanyPhone { get; set; }

        public string LogoUrl { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<EmployeeEvent> Events { get; set; }
    }
}
