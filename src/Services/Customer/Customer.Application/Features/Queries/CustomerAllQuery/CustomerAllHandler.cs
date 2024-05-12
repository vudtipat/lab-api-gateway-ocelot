using System;
using Customer.Application.IRepository;
using MediatR;

namespace Customer.Application.Features.Queries
{
	public class CustomerAllHandler: IRequestHandler<CustomerAllQuery,List<Domain.Model.Customer>>
	{
		private ICustomerRepository _customerRepository;
		public CustomerAllHandler(ICustomerRepository customerRepository)
		{
            _customerRepository = customerRepository;
        }

		public async Task<List<Domain.Model.Customer>> Handle(CustomerAllQuery request,CancellationToken cancellationToken)
		{
			var result = await _customerRepository.GetCustomerAll();

			return result;
		}
	}
}

