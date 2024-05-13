using System;
using Customer.Application.IRepository;
using Customer.Domain.Model;
using MediatR;

namespace Customer.Application.Features.Queries
{
	public class GetAddressQueryHandler: IRequestHandler<GetAddressQuery,Address>
	{
		private IAddressRepository _addressRepository;
		public GetAddressQueryHandler(IAddressRepository addressRepository)
		{
			_addressRepository = addressRepository;

        }

        public async Task<Address> Handle(GetAddressQuery request, CancellationToken cancellationToken)
		{
			var result = await _addressRepository.GetAddressByCustId(request.customerId);

			return result;
		}
	}
}

