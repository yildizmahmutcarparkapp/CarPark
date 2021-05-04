using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarPark.Models.RequestModel.Account
{
    public class RegisterCreateModel
    {
        [Required(ErrorMessage = "Zorunlu")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Zorunlu")]
        [EmailAddress(ErrorMessage = "Email adres formatında olması gerekiyor")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Zorunlu")]
        [StringLength(100, ErrorMessage = "Minumum 6 karakter olmak zorunda", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Şifreler Eşleşmiyor")]
        public string ConfirmPassword { get; set; }
    }
}
