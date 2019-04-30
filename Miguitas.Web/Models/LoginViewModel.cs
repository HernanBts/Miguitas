namespace Miguitas.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

}
