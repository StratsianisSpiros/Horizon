using Entities.UtilityModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class EmployeeUser : ApplicationUser
    {
        [Display(Name = "Address")]
        [StringLength(50, ErrorMessage = "Maximum characters allowed is 50")]
        public string Address { get; set; }

        [Display(Name = "Pay Rate")]
        public decimal PayRate { get; set; }

        [Display(Name = "Overtime Pay Rate")]
        public decimal OverTimeRate { get; set; }

        [Display(Name = "Payment option")]
        public PayMethod PayMethod { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }

        [Display(Name = "Tax")]
        public int TaxRate { get; set; }

        public string AvatarUrl { get; set; }

        public ICollection<EmployeeEvent> EmployeeEvent { get; set; }

        public ICollection<Request> Requests { get; set; }

        public ICollection<Payment> Payments { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<EmployeeUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
