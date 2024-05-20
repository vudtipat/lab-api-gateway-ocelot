using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Customer.Application.Features.Commands;
using Customer.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customer.Api.Controllers
{
    [Route("/api/v1/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            var response = await _mediator.Send(new TestCQRSQuery());
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomerAll()
        {
            var response = await _mediator.Send(new CustomerAllQuery());

            return Ok(response);
        }

        [HttpGet("me")]
        public async Task<IActionResult> CustomerMeQueryAsync([FromHeader] Guid customerId)
        {
            var response = await _mediator.Send(new CustomerMeQuery()
            {
                CustomerID = customerId
            });

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerCommandAsync([FromBody] Domain.Model.Customer customer)
        {
            await _mediator.Send(new AddCustomerCommand() { customer = customer});
            return Created("",null);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomerCommandAsync([FromQuery] Guid customerId)
        {
            await _mediator.Send(new DeleteCustomerCommand() { customerId = customerId });
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> EditCustomerCommandAsync([FromBody] Domain.Model.Customer customer)
        {
            await _mediator.Send(new EditCustomerCommand() { customer = customer });
            return NoContent();
        }
    }
}

