using System;
using Microsoft.EntityFrameworkCore;
using Product.Infrastructure.Persistance.Configurations;

namespace Product.Infrastructure.Persistance
{
	public class ProductContext: DbContext
    {
		public ProductContext() { }
		
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfigution());

        }

        //Uncomment this section when want to migrate to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=10.211.55.3,1433;Database=DEV_PRODUCT;Trusted_Connection=True;MultipleActiveResultSets=true; Integrated Security=false;User ID=sa;Password=P@ssw0rd;TrustServerCertificate=True;");
        }
    }
}

