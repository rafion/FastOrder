using FastOrder.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastOrder.Domain.Data.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order_");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DisplayValue)
                .IsRequired(true)
                .HasMaxLength(32)
                .HasColumnType("VARCHAR(32)");
        }
    }
}
