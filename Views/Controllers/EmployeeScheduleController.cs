using Entities.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class EmployeeScheduleController : BaseEmployeeController
    {
        // GET: Schedule
        public ActionResult Index()
        {
            BaseViewModel model = new BaseViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
            };

            return View(model);
        }

        public async Task<JsonResult> GetEvents()
        {
            var user = await _employeeRepository.GetEmployeeWithEventsAsync(CurrentUser);

            return new JsonResult { Data = user.EmployeeEvent, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}