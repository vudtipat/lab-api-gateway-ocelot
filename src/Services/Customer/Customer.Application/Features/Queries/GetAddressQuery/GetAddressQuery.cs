using System;
using Customer.Domain.Model;
using MediatR;

namespace Customer.Application.Features.Queries
{
	public class GetAddressQuery: IRequest<Address>
	{
		public string customerId { set; get; }
	}
}

