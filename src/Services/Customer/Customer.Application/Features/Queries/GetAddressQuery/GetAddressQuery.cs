using System;
using Customer.Domain.Model;
using MediatR;

namespace Customer.Application.Features.Queries
{
	public class GetAddressQuery: IRequest<Address>
	{
		public Guid customerId { set; get; }
	}
}

