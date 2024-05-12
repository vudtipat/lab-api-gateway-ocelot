using System;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class DeleteCustomerCommand: IRequest
	{
		public string customerId { set; get; }
	}
}

