using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class RegisterUserModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "Username is too long.")]
        [Display(Name = "Username")]
        public string? UserName { get; set; }
        
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }
        
        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Password is not valid, Please use a-Z and 0-9")]
        [Display(Name = "Password")]
        public string? Password { get; set; }
        
        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Password is not valid, Please use a-Z and 0-9 ")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm Password")]
        public string? PasswordRepeat { get; set; }
    }
}