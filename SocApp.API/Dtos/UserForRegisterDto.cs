using System.ComponentModel.DataAnnotations;

namespace SocApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6, ErrorMessage="You must specify password between 6 and 10 characters")]
        public string Password { get; set; }
    }
}