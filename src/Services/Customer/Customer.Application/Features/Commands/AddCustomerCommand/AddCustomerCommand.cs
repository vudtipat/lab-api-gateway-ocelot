using System;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class AddCustomerCommand: IRequest
	{
		public Domain.Model.Customer customer { set; get; }
	}
}

