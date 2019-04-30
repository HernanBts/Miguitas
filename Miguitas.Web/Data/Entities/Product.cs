namespace Miguitas.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Product : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "El {0} solo puedo tener {1} caracteres como maximo.")]
        [Required(ErrorMessage = "Debe ingresar un {0}.")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Debe ingresar un {0}.")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Debe ingresar un {0}.")]
        public decimal Price { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [Display(Name = "Disponible?")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }

                //TODO: Chango when publish.
                //return $"https://miguitas.azurewebsites.net{this.ImageUrl.Substring(1)}";
                return $"https://miguitas-web.conveyor.cloud{this.ImageUrl.Substring(1)}";
            }
        }


        public User User { get; set; }
    }
}
