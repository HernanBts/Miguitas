namespace Miguitas.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ChangeUserViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
    }

}
