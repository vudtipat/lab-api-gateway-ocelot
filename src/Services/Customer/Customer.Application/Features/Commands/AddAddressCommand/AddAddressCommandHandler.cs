using System;
using Customer.Application.IRepository;
using Customer.Domain.Model;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class AddAddressCommandHandler: IRequestHandler<AddAddressCommand>
	{
		private IAddressRepository _addressRepository;
		public AddAddressCommandHandler(IAddressRepository addressRepository)
		{
			_addressRepository = addressRepository;
        }

		public async Task Handle(AddAddressCommand request,CancellationToken cancellationToken)
		{
			await _addressRepository.AddAddress(request.address);
        }
	}
}

