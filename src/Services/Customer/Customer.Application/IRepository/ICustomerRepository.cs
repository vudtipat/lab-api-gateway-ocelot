using System;
namespace Customer.Application.IRepository
{
	public interface ICustomerRepository: IDisposable
    {
        Task<Domain.Model.Customer> GetCustomerById(Guid customerId);
        Task<List<Domain.Model.Customer>> GetCustomerAll();
        Task AddCustomer(Domain.Model.Customer customer);
        void RemoveCustomerById(Guid customerId);
        void UpdateCustomer(Domain.Model.Customer customer);
	}
}

