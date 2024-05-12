using System;
namespace Customer.Application.IRepository
{
	public interface ICustomerRepository: IDisposable
    {
        Task<Domain.Model.Customer> GetCustomerById(string customerId);
        Task<List<Domain.Model.Customer>> GetCustomerAll();
        void AddCustomer(Domain.Model.Customer customer);
        void RemoveCustomerById(string customerId);
        void UpdateCustomer(Domain.Model.Customer customer);
	}
}

