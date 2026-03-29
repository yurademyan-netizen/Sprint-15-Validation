using System.ComponentModel.DataAnnotations; // yura ts 1

namespace ProductsValidation.Models
{
  
    public enum ProductType
    {
        [Display(Name = "Toy")]
        Toy,

        [Display(Name = "Technique")]
        Technique,

        [Display(Name = "Clothes")]
        Clothes,

        [Display(Name = "Transport")]
        Transport
    }
}
// ts 1