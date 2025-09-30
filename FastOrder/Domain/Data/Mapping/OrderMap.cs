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

            builder.Property(o => o.OrderDate).IsRequired().HasDefaultValueSql("NOW()");
            builder.Property(o => o.TotalAmount).HasColumnType("decimal(18, 2)");


            builder.HasMany(o => o.Items)
            .WithOne(oi => oi.Order)
            //.HasForeignKey(oi => oi.Order) // Chave estrangeira em OrderItem não informa fica implicita
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
