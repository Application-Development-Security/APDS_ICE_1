using System.ComponentModel.DataAnnotations;

namespace APDS_ICE_1.Models
{
    public class RegistrationViewModel
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "First name is required")]
        [MaxLength(50, ErrorMessage = "The max length is 50 characters")]

        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(50, ErrorMessage = "The max length is 50 characters")]
        public string LastName { get; set; }



        [Required(ErrorMessage = "Email is required")]
        [MaxLength(100, ErrorMessage = "The max length is 100 characters")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid Email.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Username is required")]
        [MaxLength(20, ErrorMessage = "The max length is 20 characters")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [MaxLength(20, ErrorMessage = "The max length is 20 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Please confirm password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
