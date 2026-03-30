using FluentValidation;
using Microsoft.AspNetCore.Http;
using ProductsValidation.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace ProductsValidation.CustomValidation
{
    public class CustomValidation : AbstractValidator<Product>
    {
        public CustomValidation()
        {
            RuleFor(x => x.Description)
            .MinimumLength(3)
                .WithMessage("Description must be longer than 2 characters")

            .Must((product, desc) => desc.StartsWith(product.Name))
                .WithMessage("Description should start with the Name of the product")

            .NotEqual(x => x.Name)
                .WithMessage("Description should not be equal to Name")

            .When(x => !string.IsNullOrEmpty(x.Description));
        }
    }
}
