using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APDS_ICE_1.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username or Email is required")]
        [MaxLength(20, ErrorMessage = "The max length is 20 characters")]
        [DisplayName("Username or Email")]
        public string UserNameOrdEmail { get; set; }


        [Required(ErrorMessage = "Password or is required")]
        [MaxLength(20, ErrorMessage = "The max length is 20 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
