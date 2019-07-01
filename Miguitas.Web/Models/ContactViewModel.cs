namespace Miguitas.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        [StringLength(60, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Telefono")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Asunto")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Mensaje")]
        public string Message { get; set; }
    }
}
