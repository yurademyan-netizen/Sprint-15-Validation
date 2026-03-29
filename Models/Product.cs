using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsValidation.Models
{
    public class Product
    {
        public enum Category { Toy, Technique, Clothes, Transport}

        public int Id { get; set; }
        public Category Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
