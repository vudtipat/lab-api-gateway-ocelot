using System;
using Customer.Application.IRepository;
using MediatR;

namespace Customer.Application.Features.Commands
{
	public class DeleteAddressCommandHandler: IRequestHandler<DeleteAddressCommand>
	{
		private IAddressRepository _addressRepository;
		public DeleteAddressCommandHandler(IAddressRepository addressRepository)
		{
			_addressRepository = addressRepository;
		}

		public async Task Handle(DeleteAddressCommand request,CancellationToken cancellationToken)
		{
			await Task.Run(() => _addressRepository.RemoveAddressByCustId(request.customerId));
		}

	}
}

