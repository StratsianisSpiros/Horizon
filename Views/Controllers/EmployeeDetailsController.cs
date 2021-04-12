using Entities.EmployeeViewModels;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Views.Controllers.BaseControllers;

namespace Views.Controllers
{
    public class EmployeeDetailsController : BaseEmployeeController
    {
        // GET: EmployeeDetails
        public async Task<ActionResult> Index(string message)
        {
            var user = await _employeeRepository.GetEmployeeAsync(CurrentUser);

            if (string.IsNullOrEmpty(user.AvatarUrl))
                user.AvatarUrl = "~/EmployeeAvatars/Default.jpg";

            EmployeeUploadAvatar model = new EmployeeUploadAvatar
            {
                LoggedCompany = CurrentCompany, //BaseViewModel
                LoggedUser = CurrentUser, //BaseViewModel
                LogoUrl = CurrentLogoUrl, //BaseViewModel
                Message = message,

                Employee = user         
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UploadAvatar(EmployeeUploadAvatar model)
        {
            var user = await _employeeRepository.GetEmployeeAsync(CurrentUser);
            string fileCurrentPath = Server.MapPath(user.AvatarUrl);

            if (ModelState.IsValid)
            {               
                string pic = Path.GetFileName(model.UploadFile.FileName);
                string path = Path.Combine(Server.MapPath("~/EmployeeAvatars"), CurrentUser + pic);
                string dbPath = Url.Content("~/EmployeeAvatars/" + CurrentUser + pic);

                user.AvatarUrl = dbPath;

                var result = await _employeeRepository.UpdateEmployeeAsync(user);

                if (result.Succeeded)
                {
                    if(System.IO.File.Exists(fileCurrentPath))
                        System.IO.File.Delete(fileCurrentPath);

                    model.UploadFile.SaveAs(path);
                }        
                
                return RedirectToAction("Index", "EmployeeDetails", new { message = "File uploaded successfully" });
            }

            string errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage)).Aggregate((a, b) => a + Environment.NewLine + b);

            return RedirectToAction("Index", "EmployeeDetails", new { message = errors });
        }
    }
}