namespace Miguitas.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Country : IEntity
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "El {0} solo puedo tener {1} caracteres como maximo.")]
        [Required]
        [Display(Name = "Pais")]
        public string Name { get; set; }
    }

}
