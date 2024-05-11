using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Customer.Application.Features.Queries.CustomerQuery;
using Customer.Application.Features.Queries.TestCQRS;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customer.Api.Controllers
{
    [Route("/api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            var response = await _mediator.Send(new TestCQRSQuery());
            return Ok(response);
        }

        [HttpGet("/me")]
        public async Task<IActionResult> CustomerMeQueryAsync([FromHeader] string customerId)
        {
            var response = await _mediator.Send(new CustomerMeQuery() {
                CustomerID = customerId
            });

            return Ok(response);
        }
    }
}

