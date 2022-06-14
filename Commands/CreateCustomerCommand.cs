using CQRS.Models;
using MediatR;

namespace CQRS.Commands
{
    public record CreateCustomerCommand(string FirstName, string LastName) : IRequest<CustomerDto>;
}
