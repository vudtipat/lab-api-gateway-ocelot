using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.Application.Features.Commands;
using Customer.Application.Features.Queries;
using Customer.Domain.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customer.Api.Controllers
{
    [Route("/api/v1/addresses")]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAddressAsync()
        {
            var response = await _mediator.Send(new GetAllAddressQuery());

            return Ok(response);
        }

        [HttpGet("me")]
        public async Task<IActionResult> GetAddressAsync([FromHeader] string customerId)
        {
            var response = await _mediator.Send(new GetAddressQuery() { customerId = customerId });

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddAddressAsync([FromBody] Address address)
        {
            await _mediator.Send(new AddAddressCommand() { address = address });

            return Created("", null);
        }

        [HttpPut]
        public async Task<IActionResult> EditAddressAsync([FromBody] Address address)
        {
            await _mediator.Send(new EditAddressCommand() { address = address });

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAddressAsync([FromHeader] string customerId)
        {
            await _mediator.Send(new DeleteAddressCommand() { customerId = customerId });

            return NoContent();
        }
    }
}
