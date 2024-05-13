using System;
using Customer.Domain.Model;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class EditAddressCommand: IRequest
	{
		public Address address { set; get; }
	}
}

