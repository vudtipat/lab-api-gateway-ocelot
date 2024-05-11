using System;
using Customer.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Infrastructure.Persistance.Configurations
{
	public class AddressConfiguration: IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            entity.ToTable("ADDRESS");

            entity.HasKey(x => x.AddressId);

            entity.Property(x => x.AddressId)
                .HasColumnName("ADDRESS_ID");

            entity.Property(x => x.CustomerId)
                .HasColumnName("CUSTOMER_ID");

            entity.Property(x => x.AddressLine1)
                .HasColumnName("ADDRESS_LINE1");

            entity.Property(x => x.AddressLine2)
                .HasColumnName("ADDRESS_LINE2");

            entity.Property(x => x.SubDistrict)
                .HasColumnName("SUB_DISTRICT");

            entity.Property(x => x.District)
                .HasColumnName("DISTRICT");

            entity.Property(x => x.Province)
              .HasColumnName("PROVINCE");

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

