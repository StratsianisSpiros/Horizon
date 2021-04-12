using Entities.Models;
using Entities.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class EmployeeDashboardController : BaseEmployeeController
    {
        // GET: Dashboard
        public async Task<ActionResult> Index()
        {
            var company = await _companyRepository.GetCompanyWithPostsAsync(CurrentCompanyId);
            var posts = company.Posts != null ? company.Posts.ToList() : new List<Post>();

            DashBoardViewModel model = new DashBoardViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel

                Posts = posts
            };

            return View(model);
        }

        public async Task<JsonResult> GetPosts()
        {
            var company = await _companyRepository.GetCompanyWithPostsAsync(CurrentCompanyId);
            var posts = company.Posts != null ? company.Posts.ToList() : new List<Post>();
            posts = posts.OrderByDescending(p => p.PostDate).ToList();
            return new JsonResult { Data = posts, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


    }
}