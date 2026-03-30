using System.Collections.Generic;

namespace ProductsValidation.Models
{
    public class BulkEditViewModel
    {
       
        public Product.Category Category { get; set; } // ts 4 yura
      
        public List<Product> Products { get; set; } 
    }
}