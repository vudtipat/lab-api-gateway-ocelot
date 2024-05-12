using System;
using Customer.Application.IRepository;
using Customer.Domain.Model;
using Customer.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Customer.Infrastructure.Repository
{
	public class AddressRepository: IAddressRepository, IDisposable
    {
        private CustomerContext _context;
        public AddressRepository(CustomerContext context)
		{
            _context = context;
        }

        public async Task<Address> GetAddressByCustId(string customerId)
        {
            return await _context.Address.Where(p => p.CustomerId == customerId).FirstOrDefaultAsync();
        }

        public async Task<List<Address>> GetAddressAll()
        {
            return await _context.Address.ToListAsync();
        }

        public async Task AddAddress(Address address)
        {
            await _context.Address.AddAsync(address);
            _context.SaveChanges();
        }

        public void RemoveAddressByCustId(string customerId)
        {
            var address = _context.Address.Where(p => p.CustomerId == customerId).FirstOrDefault();
            _context.Address.Remove(address);
            _context.SaveChanges();
        }

        public void UpdateAddress(Address address)
        {
            _context.Address.Update(address);
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

