using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace APDS_ICE_1.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class Accounts
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
        public string Email { get; set; }


        [Required(ErrorMessage = "Username is required")]
        [MaxLength(20, ErrorMessage = "The max length is 20 characters")]
        public string  UserName { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [MaxLength(20, ErrorMessage = "The max length is 20 characters")]
        public string Password { get; set; }
        
    }
}
