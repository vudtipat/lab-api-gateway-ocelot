using System;
using Microsoft.EntityFrameworkCore;
using Payment.Infrastructure.Persistance.Configurations;

namespace Payment.Infrastructure.Persistance
{
	public class PaymentContext: DbContext
    {
		public PaymentContext() { }
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
        }

        //Uncomment this section when want to migrate to database
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"connectionString");
        //}

    }
}

