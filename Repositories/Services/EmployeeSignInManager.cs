using Entities.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Repositories.Services
{
    // Creates and configures identity SignIn Manager for application Employee users
    public class EmployeeSignInManager : SignInManager<EmployeeUser, string>
    {
        public EmployeeSignInManager(EmployeeManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(EmployeeUser user)
        {
            return user.GenerateUserIdentityAsync((EmployeeManager)UserManager);
        }

        public static EmployeeSignInManager Create(IdentityFactoryOptions<EmployeeSignInManager> options, IOwinContext context)
        {
            return new EmployeeSignInManager(context.GetUserManager<EmployeeManager>(), context.Authentication);
        }
    }
}
