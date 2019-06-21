namespace Miguitas.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password")]
        public string Confirm { get; set; }
    }
}
