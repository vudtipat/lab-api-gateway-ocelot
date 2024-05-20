using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.Model;

namespace Product.Infrastructure.Persistance.Configurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> entity)
        {
            entity.ToTable("Product");

            entity.HasKey(x => x.ProductId);

            entity.Property(x => x.ProductId)
                .HasColumnName("PRODUCT_ID");

            entity.Property(x => x.ProductName)
                .HasColumnName("PRODUCT_NAME");

            entity.Property(x => x.Description)
                .HasColumnName("DESCRIPTION");

            entity.Property(x => x.CategoryId)
                .HasColumnName("CATEGORY_ID");

            entity.Property(x => x.Price)
                .HasColumnName("PRICE");

            entity.Property(x => x.InventoryCount)
                .HasColumnName("INVENTORY_COUNT");

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

