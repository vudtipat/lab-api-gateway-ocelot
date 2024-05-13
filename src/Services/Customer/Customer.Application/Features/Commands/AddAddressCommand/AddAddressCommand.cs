using System;
using Customer.Domain.Model;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class AddAddressCommand: IRequest
	{
		public Address address { get; set; }
	}
}

