using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Order.Domain.Enum;
using Order.Domain.Model;
namespace Order.Infrastructure.Persistance.Configurations
{
	public class OrdersConfiguration: IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> entity)
        {
            entity.ToTable("Orders");

            entity.HasKey(x => x.OrderId);

            entity.Property(x => x.OrderId)
                .HasColumnName("ORDER_ID");

            entity.Property(x => x.CustomerId)
                .HasColumnName("CUSTOMER_ID");

            entity.Property(x => x.OrderDate)
                .HasColumnName("ORDER_DATE");

            entity.Property(x => x.Status)
                .HasColumnName("STATUS");

            entity.Property(x => x.TotalAmount)
                .HasColumnName("TOTAL_AMOUNT");

            entity.Property(x => x.CreatedBy)
                .HasColumnName("CREATED_BT");

            entity.Property(x => x.CreatedAt)
                .HasColumnName("CREATED_AT");

            entity.Property(x => x.UpdatedBy)
                .HasColumnName("UPDATED_BY");

            entity.Property(x => x.UpdatedAt)
                .HasColumnName("UPDATED_AT");

        }
    }
}

