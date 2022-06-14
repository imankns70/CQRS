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
        public CreateCustomerCommandHandler(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(CreateCustomerCommand createCustomerCommand, CancellationToken cancellationToken)
        {
            Customer customer =_mapper.Map<Customer>(createCustomerCommand);

            await _context.Customers.AddAsync(customer, cancellationToken);
            await _context.SaveChangesAsync();

            return _mapper.Map<CustomerDto>(customer);
             
        }
    }
}
