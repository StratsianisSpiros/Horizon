using System.Web.Mvc;
using Views.Controllers.BaseControllers;
using Stripe.Checkout;
using Repositories.Services;
using Entities.UtilityModels;
using System.Threading.Tasks;
using Entities.AdminViewModels;

namespace Views.Controllers
{
    public class AdminSubscriptionController : BaseAdminController
    {
        // GET: Subscription
        public async Task<ActionResult> Index(string message)
        {

            var user = await _adminRepository.GetUserAsync(CurrentUser);
            var company = await _companyRepository.GetCompanyWithPostsAsync(CurrentCompanyId);

            AdminDetailsViewModel model = new AdminDetailsViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                Message = message, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Company = company,
                AdminUser = user
            };

            return View(model);
        }

        public ActionResult CreateSession(string priceId)
        {
            Session session = SubscribeService.CreateSession(priceId);
            return View(session);
        }

        public async Task<ActionResult> Success(string session_id)
        {
            var user = await _adminRepository.GetUserAsync(CurrentUser);
            SubscriptionModel subscriptionModel = SubscribeService.Success(session_id, CurrentCompany);
            user.SubscriptionId = subscriptionModel.SubscriptionId;
            user.SubsciptionStatus = subscriptionModel.SubsciptionStatus;
            await _adminRepository.UpdateUserAsync(user);
            return RedirectToAction("Index", "AdminSubscription", new { message = "You subscribed successfully" });
        }

        public async Task<ActionResult> Unsubscribe()
        {
            var user = await _adminRepository.GetUserAsync(CurrentUser);
            user.SubsciptionStatus = SubscribeService.Unsubscribe(user.SubscriptionId);
            await _adminRepository.UpdateUserAsync(user);
            return RedirectToAction("Index", "AdminSubscription", new { message = "You unsubscribed successfully" });
        }

    }
}