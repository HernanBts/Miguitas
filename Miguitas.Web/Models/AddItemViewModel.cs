namespace Miguitas.Web.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AddItemViewModel
    {
        [Display(Name = "Producto")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un producto.")]
        public int ProductId { get; set; }

        [Range(0.0001, double.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0.")]
        public double Quantity { get; set; }

        public IEnumerable<SelectListItem> Products { get; set; }
    }

}
