using System;
using Microsoft.EntityFrameworkCore;
using Order.Infrastructure.Persistance.Configurations;

namespace Order.Infrastructure.Persistance
{
	public class OrderContext: DbContext
    {
		public OrderContext() { }
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.ApplyConfiguration(new OrdersConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
        }

        //Uncomment this section when want to migrate to database
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"connectionString");
        //}
    }
}

