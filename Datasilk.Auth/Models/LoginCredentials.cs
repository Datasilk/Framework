using System.ComponentModel.DataAnnotations;

namespace Datasilk.Auth.Models
{
    public class LoginCredentials
    {
        [Required]
        public string Username { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";
    }
}
