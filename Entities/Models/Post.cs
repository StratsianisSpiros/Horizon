using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Display(Name = "Subject")]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Posted")]
        public DateTime? PostDate { get; set; }

        public int CompanyId { get; set; }
    }
}
