using Customer.Domain.Model;
using Customer.Infrastructure.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Customer.Infrastructure.Persistance
{
    public partial class CustomerContext: DbContext
    {
        public CustomerContext(){}
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }

        public DbSet<Customer.Domain.Model.Customer> Customer { set; get; }
        public DbSet<Address> Address { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());

            modelBuilder.Entity<Customer.Domain.Model.Customer>()
                .Property(e => e.CustomerID)
                .ValueGeneratedOnAdd();
        }

        //Uncomment this section when want to migrate to database
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"connectionString");
        //}
    }
}