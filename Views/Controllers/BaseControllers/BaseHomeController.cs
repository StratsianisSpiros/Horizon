using Microsoft.AspNet.Identity.Owin;
using Repositories.Repository;
using Repositories.Services;
using System.Web;
using System.Web.Mvc;

namespace Views.Controllers.BaseControllers
{
    /// <summary>
    /// Base Controller for login page and exposes repositories required <br/>
    /// for registering kai login
    /// </summary>
    [AllowAnonymous]
    public class BaseHomeController : Controller
    {
        // GET: BaseHome
        private AdminSignInManager _adminSignInManager;
        private AdminManager _adminManager;
        private EmployeeSignInManager _employeeSignInManager;
        protected CompanyRepository _companyRepository = new CompanyRepository();

        public BaseHomeController()
        {

        }

        public BaseHomeController(AdminManager adminManager, AdminSignInManager adminSignInManager, EmployeeSignInManager employeeSignInManager)
        {
            AdminUserManager = adminManager;
            AdminSignInManager = adminSignInManager;
            _employeeSignInManager = employeeSignInManager;
        }

        public AdminSignInManager AdminSignInManager
        {
            get => _adminSignInManager ?? HttpContext.GetOwinContext().Get<AdminSignInManager>();
            private set => _adminSignInManager = value;
        }

        public EmployeeSignInManager EmployeeSignInManager
        {
            get => _employeeSignInManager ?? HttpContext.GetOwinContext().Get<EmployeeSignInManager>();
            private set => _employeeSignInManager = value;
        }

        public AdminManager AdminUserManager
        {
            get => _adminManager ?? HttpContext.GetOwinContext().GetUserManager<AdminManager>();
            private set => _adminManager = value;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _companyRepository.Dispose();

                if (_adminManager != null)
                {
                    _adminManager.Dispose();
                    _adminManager = null;
                }

                if (_adminSignInManager != null)
                {
                    _adminSignInManager.Dispose();
                    _adminSignInManager = null;
                }

                if (_employeeSignInManager != null)
                {
                    _employeeSignInManager.Dispose();
                    _employeeSignInManager = null;
                }
            }
            base.Dispose(disposing);
        }
    }
}