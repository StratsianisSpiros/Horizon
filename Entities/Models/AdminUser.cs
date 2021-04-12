using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AdminUser : ApplicationUser
    { 
        public string SubscriptionId { get; set; }

        public string SubsciptionStatus { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AdminUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
