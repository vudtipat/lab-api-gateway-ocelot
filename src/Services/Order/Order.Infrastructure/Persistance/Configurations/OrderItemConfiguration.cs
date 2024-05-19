using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Order.Domain.Model;

namespace Order.Infrastructure.Persistance.Configurations
{
	public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> entity)
        {
            entity.ToTable("OrderItem");

            entity.HasKey(x => x.OrderItemId);

            entity.Property(x => x.OrderItemId)
                .HasColumnName("ORDERITEM_ID");

            entity.Property(x => x.OrderId)
                .HasColumnName("ORDER_ID");

            entity.Property(x => x.ProductId)
                .HasColumnName("PRODUCT_ID");

            entity.Property(x => x.Quantity)
                .HasColumnName("QUANTITY");

            entity.Property(x => x.UnitPrice)
                .HasColumnName("UNIT_PRICE");

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

