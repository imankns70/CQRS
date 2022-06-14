using CQRS.Queries;
using FluentValidation;

namespace CQRS.Validation
{
    public class CreateCustomerCommandValidator: AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(customer => customer.FirstName).NotEmpty(); 
            RuleFor(customer => customer.LastName).NotEmpty(); 
        }
    }
}
