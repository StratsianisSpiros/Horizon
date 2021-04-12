using Entities.Models;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class AdminDashboardController : BaseAdminController
    {
        // GET: AdminDashboardController
        public async Task<ActionResult> Index(string message, int? startIndex)
        {
            var company = await _companyRepository.GetCompanyWithPostsAsync(CurrentCompanyId);
            var posts = company.Posts != null ? company.Posts.ToList() : new List<Post>();

            int currentIndex = startIndex ?? 0;
            int currentPage = 8;

            posts = posts.OrderByDescending(p => p.PostDate).ToList();

            var page = posts.Skip(currentIndex).Take(currentPage);

            DashBoardViewModel model = new DashBoardViewModel
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentCompany, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
                Message = message, //BaseViewModel

                CurrentIndex = currentIndex, //Paged
                CurrentPage = currentPage, //Paged
                MaxIndex = posts.Count(), //Paged

                Posts = page.ToList()
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


        [HttpPost]
        public async Task<JsonResult> Submit(Post e)
        {
            var status = false;
            IFormatProvider culture = new CultureInfo("en-US", true);
            Post post = new Post()
            {
                Content = e.Content,
                PostDate = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                status = await _companyRepository.CreateCompanyPostAsync(post, CurrentCompanyId);
            }

            return new JsonResult { Data = new { status = status } };
        }


        [HttpPost]
        public async Task<JsonResult> Update(Post e)
        {
            var status = false;
            Post post = new Post()
            {
                Content = e.Content,
                PostDate = DateTime.Now,
                PostId = e.PostId,
                CompanyId = CurrentCompanyId
            };



            if (ModelState.IsValid)
            {
                status = await _companyRepository.UpdateCompanyPostAsync(post);
            }

            return new JsonResult { Data = new { status = status } };
        }


        public async Task<ActionResult> Delete(Post post)
        {
            var status = false;
            status = await _companyRepository.DeleteCompanyPostAsync(post.PostId);
            return new JsonResult { Data = new { status = status } };
        }

    }
}