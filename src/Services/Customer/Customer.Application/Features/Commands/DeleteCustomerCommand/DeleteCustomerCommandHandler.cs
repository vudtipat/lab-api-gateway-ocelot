using System;
using Customer.Application.IRepository;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class DeleteCustomerCommandHandler: IRequestHandler<DeleteCustomerCommand>
	{
        private ICustomerRepository _customerrepository;
        public DeleteCustomerCommandHandler(ICustomerRepository customerrepository)
        {
            _customerrepository = customerrepository;
        }

        public async Task Handle(DeleteCustomerCommand request,CancellationToken cancellationToken)
		{
            _customerrepository.RemoveCustomerById(request.customerId);
        }
	}
}

