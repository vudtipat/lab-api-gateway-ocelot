using System;
namespace Customer.Application.IRepository
{
	public interface ICustomerRepository: IDisposable
    {
        Task<Domain.Model.Customer> GetCustomerById(string customerId);
	}
}

