namespace Miguitas.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name = "Contraseña acutal")]
        public string OldPassword { get; set; }

        [Required]
        [Display(Name = "Contraseña nueva")]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }

}
