using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.Model;

namespace Product.Infrastructure.Persistance.Configurations
{
	public class CategoryConfigution : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.ToTable("Category");

            entity.HasKey(x => x.CategoryId);

            entity.Property(x => x.CategoryId)
                .HasColumnName("CATEGORY_ID");

            entity.Property(x => x.CategoryName)
                .HasColumnName("ORDER_ID");
         
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

