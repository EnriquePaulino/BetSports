using System.ComponentModel.DataAnnotations;

namespace BetSports.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [MinLength(3)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

