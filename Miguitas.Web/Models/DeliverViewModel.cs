namespace Miguitas.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DeliverViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Fecha envio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime DeliveryDate { get; set; }
    }
}
