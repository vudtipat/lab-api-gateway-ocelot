using System;
using MediatR;

namespace Customer.Application.Features.Queries
{
	public class CustomerMeQuery: IRequest<Domain.Model.Customer>
	{
		public string CustomerID { set; get; }	
	}
}

