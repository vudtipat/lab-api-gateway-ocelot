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

		public async Task<Domain.Model.Customer> GetCustomerById(string customerId)
		{
			return await _context.Customer.Where(p => p.CustomerID == customerId).FirstOrDefaultAsync();
		}

        public async Task<List<Domain.Model.Customer>> GetCustomerAll(){
            return await _context.Customer.ToListAsync();
        }

        public async void AddCustomer(Domain.Model.Customer customer)
        {
            await _context.Customer.AddAsync(customer);
            _context.SaveChanges();
        }

        public void RemoveCustomerById(string customerId)
        {
            var customer = _context.Customer.Where(p => p.CustomerID == customerId).FirstOrDefault();
            _context.Customer.Remove(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Domain.Model.Customer customer)
        {
            _context.Customer.Update(customer);
            _context.SaveChanges();
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

