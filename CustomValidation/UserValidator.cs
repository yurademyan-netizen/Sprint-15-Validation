using FluentValidation;
using ProductsValidation.Models;

namespace ProductsValidation.CustomValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty();

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Incorrect email address format")
                .Length(2, 50).WithMessage("Name must be between 2 and 50 characters");

            RuleFor(x => x.Role).NotEmpty().WithMessage("Role is required");
        }
    }
}
