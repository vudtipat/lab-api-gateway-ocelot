using System;
using Customer.Domain.Model;

namespace Customer.Application.IRepository
{
	public interface IAddressRepository: IDisposable
    {
        Task<Address> GetAddressByCustId(string customerId);
        Task<List<Address>> GetAddressAll();
        Task AddAddress(Address address);
        void RemoveAddressByCustId(string customerId);
        void UpdateAddress(Address address);
    }
}

