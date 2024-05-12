using System;
using MediatR;

namespace Customer.Application.Features.Queries
{
	public class CustomerAllQuery: IRequest<List<Domain.Model.Customer>>
	{
		
	}
}

