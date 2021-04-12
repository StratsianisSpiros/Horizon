using Entities.Models;
using Entities.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Repositories.Services;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class HomeController : BaseHomeController
    {
        public ActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AdminUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    CompanyName = model.CompanyName,
                    IsAdmin = true,
                    SubsciptionStatus = "Free Plan"
                };

                var result = await AdminUserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var company = await _companyRepository.CreateCompanyAsync(model.CompanyName);
                    user.CompanyId = company.CompanyId;
                    await AdminUserManager.UpdateAsync(user);
                    result = await AdminUserManager.AddToRoleAsync(user.Id, "Admin");
                } 

                if (result.Succeeded)
                {
                    await AdminSignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    return RedirectToAction("Index", "Admin");
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = await AdminSignInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent:true, shouldLockout: false);
      
            if (result == SignInStatus.Success)
                return RedirectToAction("Index", "Admin");

            result = await EmployeeSignInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent:true , shouldLockout: false);

            if (result == SignInStatus.Success)
                return RedirectToAction("Index", "Employee");

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(model);
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Login", "Home");
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}