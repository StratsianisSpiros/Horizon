using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.ViewModels
{
    public class PostViewModel : BaseViewModel
    {
        public int PostId { get; set; }

        [Display(Name = "Subject")]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Posted")]
        public DateTime? PostDate { get; set; }
        public int CompanyId { get; set; }
    }
}
