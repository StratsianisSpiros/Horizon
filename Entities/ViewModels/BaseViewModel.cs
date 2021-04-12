using Entities.UtilityModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Entities.ViewModels
{
    public class BaseViewModel : PagedView
    {
        [Display(Name = "Company")]
        public string LoggedCompany { get; set; }

        [Display(Name = "User")]
        public string LoggedUser { get; set; }

        public string Message { get; set; }

        public string LogoUrl { get; set; }

        [Display(Name = "Date")]
        public string DateNow => DateTime.Now.ToString("dd-MMMM-yyyy", new CultureInfo("en-GB"));
    }
}
