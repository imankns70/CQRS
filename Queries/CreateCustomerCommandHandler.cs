using AutoMapper;
using CQRS.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Queries
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
    {
        readonly ApplicationDbContext _context;
        readonly IMapper _mapper;
        public Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
