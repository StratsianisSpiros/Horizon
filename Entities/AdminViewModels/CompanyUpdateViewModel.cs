using Entities.CustomValidations;
using Entities.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Entities.AdminViewModels
{
    public class CompanyUpdateViewModel : BaseViewModel
    {
        [Display(Name = "Company")]
        [StringLength(20, ErrorMessage = "Maximum characters allowed is 20")]
        public string CompanyName { get; set; }

        [Display(Name = "Address")]
        [StringLength(50, ErrorMessage = "Maximum characters allowed is 50")]
        public string CompanyAddress { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Phone number need 10 digits")]
        public string CompanyPhone { get; set; }

        [CustomFilevalidation(MaxFileSize = 2, AllowedFormats = new[] { ".jpg", ".png", ".bmp", ".jpeg" })]
        public HttpPostedFileBase UploadFile { get; set; }
    }
}
