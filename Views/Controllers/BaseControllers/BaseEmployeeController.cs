using Microsoft.AspNet.Identity;
using Repositories.Repository;
using System.Web.Mvc;

namespace Views.Controllers.BaseControllers
{
    /// <summary>
    /// Base Controller for all employee controllers that authorizes and exposes repositories required for admin <br/>
    /// and also properties to be used on most methods
    /// </summary>
    [Authorize(Roles = "Employee")]
    public class BaseEmployeeController : Controller
    {
        // GET: BaseEmployee
        protected EmployeeRepository _employeeRepository = new EmployeeRepository();
        protected CompanyRepository _companyRepository = new CompanyRepository();
        protected string CurrentUser => User.Identity.GetUserName() ?? "User";
        protected int CurrentCompanyId => !string.IsNullOrEmpty(User.Identity.GetUserId()) ? _employeeRepository.GetCompanyId(User.Identity.GetUserId()) : -1;
        protected string CurrentCompany => !string.IsNullOrEmpty(User.Identity.GetUserId()) ? _employeeRepository.GetCompany(User.Identity.GetUserId()) : "HORIZON";
        protected string CurrentLogoUrl => _companyRepository.GetCompany(CurrentCompanyId).LogoUrl ?? "~/CompanyLogo/Default.jpg";
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _employeeRepository.Dispose();
                _companyRepository.Dispose();

                if (_employeeRepository != null)
                {
                    _employeeRepository.Dispose();
                    _employeeRepository = null;
                }
            }

            base.Dispose(disposing);
        }
    }
}