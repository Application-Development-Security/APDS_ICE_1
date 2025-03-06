using System.ComponentModel.DataAnnotations;

namespace APDS_ICE_1.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [MaxLength(20, ErrorMessage = "The max length is 20 characters")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [MaxLength(20, ErrorMessage = "The max length is 20 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
