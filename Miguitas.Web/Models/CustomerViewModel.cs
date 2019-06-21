using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miguitas.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CustomerViewModel
    {
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Direccion")]
        public string Addres { get; set; }
    }
}
