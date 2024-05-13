using System;
using Customer.Application.IRepository;
using Customer.Domain.Model;
using MediatR;

namespace Customer.Application.Features.Queries
{
	public class GetAllAddressQueryHandler: IRequestHandler<GetAllAddressQuery,List<Address>>
	{
		private IAddressRepository _addressRepository;
		public GetAllAddressQueryHandler(IAddressRepository addressRepository)
		{
			_addressRepository = addressRepository;
        }

		public async Task<List<Address>> Handle(GetAllAddressQuery request,CancellationToken cancellationToken)
		{
			var result = await _addressRepository.GetAddressAll();
			return result;
        }
    }
}

