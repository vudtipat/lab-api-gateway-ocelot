using System;
using Customer.Domain.Model;

namespace Customer.Application.IRepository
{
	public interface IAddressRepository: IDisposable
    {
        Task<Address> GetAddressByCustId(Guid customerId);
        Task<List<Address>> GetAddressAll();
        Task AddAddress(Address address);
        void RemoveAddressByCustId(Guid customerId);
        void UpdateAddress(Address address);
    }
}

