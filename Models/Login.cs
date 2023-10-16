using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Email Id is required")]
        [EmailAddress(ErrorMessage ="Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

    }
}
