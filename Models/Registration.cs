using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class Registration
    {
        [Required(ErrorMessage ="User Name is required")]
        public string UserName {  get; set; }

        [Required(ErrorMessage = "Email Id is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Password is empty")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string ConfirmPassword { get; set; }
    }
}
