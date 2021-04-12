using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [StringLength(20, ErrorMessage = "Maximum characters allowed is 20")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[A-Z][A-Za-z\s]+$", ErrorMessage = "Name must start with capital and consist only from letters and whitespace")]
        public string FirstName { get; set; }

        [StringLength(20, ErrorMessage = "Maximum characters allowed is 20")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z][A-Za-z\s]+$", ErrorMessage = "Name must start with capital and consist only from letters and whitespace")]
        public string LastName { get; set; }

        public int CompanyId { get; set; }

        [StringLength(20, ErrorMessage = "Maximum characters allowed is 20")]
        public string CompanyName { get; set; }

        public bool IsAdmin { get; set; }

        [NotMapped]
        public string FullName { get => FirstName + " " + LastName; }
    }
}
