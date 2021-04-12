﻿using Entities.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Entities.AdminViewModels
{
    public class EmployeeChangePasswordViewModel : BaseViewModel
    {
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
