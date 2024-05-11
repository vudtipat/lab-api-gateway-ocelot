using System;
using Customer.Application.IRepository;
using MediatR;

namespace Customer.Application.Features.Queries.CustomerQuery
{
	public class CustomerMeHandler : IRequestHandler<CustomerMeQuery, Domain.Model.Customer>
	{
		private ICustomerRepository _customerRepositoty;

		public CustomerMeHandler(ICustomerRepository customerRepository)
		{
			_customerRepositoty = customerRepository;
        }

		public async Task<Domain.Model.Customer> Handle(CustomerMeQuery request, CancellationToken cancellationToken)
		{
			var result = await _customerRepositoty.GetCustomer(request.CustomerID); 

			return result;
		}
	}
}

