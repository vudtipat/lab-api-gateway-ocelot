using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payment.Domain.Model;

namespace Payment.Infrastructure.Persistance.Configurations
{
	public class PaymentConfiguration: IEntityTypeConfiguration<Payments>
    {
        public void Configure(EntityTypeBuilder<Payments> entity)
        {
            entity.ToTable("Payment");

            entity.HasKey(x => x.PaymentId);

            entity.Property(x => x.PaymentId)
                .HasColumnName("PAYMENT_ID");

            entity.Property(x => x.OrderId)
                .HasColumnName("ORDER_ID");

            entity.Property(x => x.PaymentDate)
                .HasColumnName("PAYMENT_DATE");

            entity.Property(x => x.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD");

            entity.Property(x => x.TotalAmount)
                .HasColumnName("TOTAL_AMOUNT");

            entity.Property(x => x.Status)
                .HasColumnName("STATUS");

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

