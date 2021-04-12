using Entities.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Repositories.Services
{
    // Creates and configures identity SignIn Manager for application Admin users
    public class AdminSignInManager : SignInManager<AdminUser, string>
    {
        public AdminSignInManager(AdminManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(AdminUser user)
        {
            return user.GenerateUserIdentityAsync((AdminManager)UserManager);
        }

        public static AdminSignInManager Create(IdentityFactoryOptions<AdminSignInManager> options, IOwinContext context)
        {
            return new AdminSignInManager(context.GetUserManager<AdminManager>(), context.Authentication);
        }
    }
}
