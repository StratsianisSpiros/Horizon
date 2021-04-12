using Entities.UtilityModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class EmployeeEvent
    {
        [Key]
        [Required]
        public int EventID { get; set; }

        [Required]
        public int CompanyID { get; set; }

        public string Username { get; set; }

        public string Description { get; set; }

        public double? Overtime { get; set; }

        [Required]
        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        [Required]
        public string Color { get; set; }

        public WorkStatus Status { get; set; }

        [Required]
        public bool IsFullDay { get; set; }
    }
}
