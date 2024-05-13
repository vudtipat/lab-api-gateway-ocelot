using System;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class DeleteAddressCommand: IRequest
	{
		public string customerId { set; get; }
	}
}

