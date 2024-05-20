using System;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class DeleteCustomerCommand: IRequest
	{
		public Guid customerId { set; get; }
	}
}

