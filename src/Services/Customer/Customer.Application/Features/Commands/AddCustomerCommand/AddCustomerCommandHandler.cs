using System;
using Customer.Application.IRepository;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class AddCustomerCommandHandler: IRequestHandler<AddCustomerCommand>
	{
		private ICustomerRepository _customerrepository;
		public AddCustomerCommandHandler(ICustomerRepository customerrepository)
		{
			_customerrepository = customerrepository;
        }

		public async Task Handle(AddCustomerCommand request,CancellationToken cancellationToken)
		{
			await _customerrepository.AddCustomer(request.customer);
        }
	}
}

