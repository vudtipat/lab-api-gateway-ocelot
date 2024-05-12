using System;
using Customer.Application.IRepository;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class EditCustomerCommandHandler: IRequestHandler<EditCustomerCommand>
	{
        private ICustomerRepository _customerrepository;
        public EditCustomerCommandHandler(ICustomerRepository customerrepository)
        {
            _customerrepository = customerrepository;
        }

        public async Task Handle(EditCustomerCommand request, CancellationToken cancellationToken)
        {
            _customerrepository.UpdateCustomer(request.customer);
        }
    }
}

