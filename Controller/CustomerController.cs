using CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS.Controller
{

    [Route("/api/{Controller}")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetCustomerById")]
        public async Task<ActionResult> GetCustomerById(int id)
        {
            return Content("");
        }

        [HttpPost]
        public async Task<ActionResult> CreateCustomer(CreateCustomerCommand createCustomerCommand)
        {
            CustomerDto customerDto = await _mediator.Send(createCustomerCommand);

            return CreatedAtAction(nameof(GetCustomerById), new { customerId= customerDto.Id }, customerDto);
        }


    
        
    }
}
