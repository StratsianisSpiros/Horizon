using Entities.CustomValidations;
using Entities.Models;
using Entities.ViewModels;
using System.Web;

namespace Entities.EmployeeViewModels
{
    public class EmployeeUploadAvatar : BaseViewModel
    {
        [CustomFilevalidation(MaxFileSize = 4, AllowedFormats = new[] { ".jpg", ".png", ".bmp", ".jpeg" })]
        public HttpPostedFileBase UploadFile { get; set; }

        public EmployeeUser Employee { get; set; }
    }
}
