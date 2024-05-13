using System;
using Customer.Domain.Model;
using MediatR;

namespace Customer.Application.Features.Queries
{
	public class GetAllAddressQuery: IRequest<List<Address>>
	{
		
	}
}

