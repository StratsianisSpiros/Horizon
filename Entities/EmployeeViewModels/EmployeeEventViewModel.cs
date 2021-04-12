using Entities.UtilityModels;
using System.ComponentModel.DataAnnotations;

namespace Entities.EmployeeViewModels
{
    public class EmployeeEventViewModel
    {
        public int EventID { get; set; }
        public int CompanyID { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public double? Overtime { get; set; }
        [Required]
        public string Start { get; set; }
        public string End { get; set; }
        [Required]
        public string Color { get; set; }
        public WorkStatus Status { get; set; }
        public bool IsFullDay { get; set; }
    }
}
