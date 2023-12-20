using collegeApi.Model;
using FluentValidation;

namespace PizzaApi.Validator
{
    public class ValidatorClass : AbstractValidator<Pizza>
    {
        public ValidatorClass()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please enter a name")
                .Length(0, 10).WithMessage("Name length should be between 0 and 10 characters");
        }
    }
}
