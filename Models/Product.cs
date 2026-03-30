using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsValidation.Models
{
    public class Product : IValidatableObject // yura ts 1
    {
        public enum Category { Toy, Technique, Clothes, Transport }

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory field")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, 100000, ErrorMessage = "Price should be within boundaries 0 and 100000")]
        public decimal Price { get; set; }

        [Required]
        public Category Type { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            //  Slava (Task 2)

            return results;
        }
    }
}