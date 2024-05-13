using System;
using Customer.Application.IRepository;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class EditAddressCommandHandler: IRequestHandler<EditAddressCommand>
	{
		private IAddressRepository _addressRepository;
		public EditAddressCommandHandler(IAddressRepository addressRepository)
		{
			_addressRepository = addressRepository;
		}

		public async Task Handle(EditAddressCommand request,CancellationToken cancellationToken)
		{
			_addressRepository.UpdateAddress(request.address);
		}
	}
}

