using FastOrder.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastOrder.Domain.Data.Mapping
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();// Or .UseSequence("my_custom_sequence");
            builder.Property(i => i.Name).IsRequired(true).HasMaxLength(160).HasColumnType("VARCHAR(160)");
            builder.Property(i => i.Sku).HasMaxLength(14).HasColumnType("VARCHAR(14)");
            builder.Property(x => x.Status).IsRequired();
            builder.Property(i => i.Price).HasColumnType("decimal(18, 2)");
            builder.Property(i => i.Reference).HasMaxLength(50).HasColumnType("VARCHAR(50)");
            builder.Property(i => i.Model).HasMaxLength(14).HasColumnType("VARCHAR(14)");
            builder.Property(i => i.Ean).HasMaxLength(14).HasColumnType("VARCHAR(14)");
            builder.Property(i => i.Unit).HasMaxLength(6).HasColumnType("VARCHAR(6)");
        }
    }
}
