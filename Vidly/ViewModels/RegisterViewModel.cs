using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        // Required for view
        [Display(Name = "First Name")]
        [MaxLength(255, ErrorMessage = "Should be less or equal 255 characters")]
        public string FirstName { get; set; }

        [Required]
        // Required for view
        [Display(Name = "Last Name")]
        [MaxLength(255, ErrorMessage = "Should be less or equal 255 characters")]
        public string LastName { get; set; }

        [Required]
        // Required for view
        public string Role { get; set; }

        [Required]
        // Required for view
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        // Required for view
        [MaxLength(50, ErrorMessage = "Should be less or equal 50 characters")]        
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}