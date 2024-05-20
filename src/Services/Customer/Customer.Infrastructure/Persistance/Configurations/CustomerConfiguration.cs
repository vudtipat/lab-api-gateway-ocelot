using System;
using Customer.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Infrastructure.Persistance.Configurations
{
	public class CustomerConfiguration: IEntityTypeConfiguration<Domain.Model.Customer>
	{
        public void Configure(EntityTypeBuilder<Domain.Model.Customer> entity)
        {
            entity.ToTable("CUSTOMER");

            entity.HasKey(x => x.CustomerID);

            entity.Property(x => x.CustomerID)
                .HasColumnName("CUSTOMER_ID");

            entity.Property(x => x.FirstNameEN)
                .HasColumnName("FIRST_NAME_EN");

            entity.Property(x => x.LastNameEN)
                .HasColumnName("LAST_NAME_EN");

            entity.Property(x => x.FirstNameTH)
                .HasColumnName("FIRST_NAME_TH");

            entity.Property(x => x.LastNameTH)
                .HasColumnName("LAST_NAME_TH");

            entity.Property(x => x.Email)
                .HasColumnName("EMAIL");

            entity.Property(x => x.Password)
                .HasColumnName("PWD");

            entity.Property(x => x.CreatedBy)
             .HasColumnName("CREATED_BY");

            entity.Property(x => x.CreatedAt)
            .HasColumnName("CREATED_AT");

            entity.Property(x => x.UpdatedBy)
                .HasColumnName("UPDATED_BY");

            entity.Property(x => x.UpdatedAt)
               .HasColumnName("UPDATED_AT");

        }
    }
}

