using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Repositories.Repository;
using Repositories.Services;
using System.Web;
using System.Web.Mvc;

namespace Views.Controllers.BaseControllers
{
    /// <summary>
    /// Base Controller for all admin controllers that authorizes and exposes repositories required for admin <br/>
    /// and also properties to be used on most methods
    /// </summary>
    [Authorize(Roles = "Admin")]
    public class BaseAdminController : Controller
    {
        // GET: BaseAdminController
        private EmployeeManager _employeeManager;
        protected AdminRepository _adminRepository = new AdminRepository();
        protected EmployeeRepository _employeeRepository = new EmployeeRepository();
        protected CompanyRepository _companyRepository = new CompanyRepository();
        protected string CurrentUser => User.Identity.GetUserName() ?? "User";
        protected int CurrentCompanyId => !string.IsNullOrEmpty(User.Identity.GetUserId()) ? _adminRepository.GetCompanyId(User.Identity.GetUserId()) : -1;
        protected string CurrentCompany => !string.IsNullOrEmpty(User.Identity.GetUserId()) ? _adminRepository.GetCompanyName(User.Identity.GetUserId()) : "HORIZON";
        protected string CurrentLogoUrl => _companyRepository.GetCompany(CurrentCompanyId).LogoUrl ?? "~/CompanyLogo/Default.jpg";

        public BaseAdminController() { }
        public BaseAdminController(EmployeeManager employeeManager)
        {
            EmployeeManager = employeeManager;
        }

        public EmployeeManager EmployeeManager
        {
            get => _employeeManager ?? HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();
            private set => _employeeManager = value;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _adminRepository.Dispose();
                _companyRepository.Dispose();
                _employeeRepository.Dispose();

                if (_employeeManager != null)
                {
                    _employeeManager.Dispose();
                    _employeeManager = null;
                }
            }

            base.Dispose(disposing);
        }
    }
}
