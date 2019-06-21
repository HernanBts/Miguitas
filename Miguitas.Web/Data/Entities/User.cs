namespace Miguitas.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Nombre completo")]
        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "El campo {0} solo puiede tener {1} caracteres.")]
        public string Address { get; set; }
    }

}
