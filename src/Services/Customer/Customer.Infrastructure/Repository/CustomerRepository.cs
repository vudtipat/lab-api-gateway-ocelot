using System;
using Customer.Application.IRepository;
using Customer.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Customer.Infrastructure.Repository
{
	public class CustomerRepository: ICustomerRepository, IDisposable
	{
		private CustomerContext _context;

		public CustomerRepository(CustomerContext context)
		{
			_context = context;
		}

		public async Task<Domain.Model.Customer> GetCustomer(string customerId)
		{
			return await _context.Customer.Where(p => p.CustomerID == customerId).FirstOrDefaultAsync();
		}

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

