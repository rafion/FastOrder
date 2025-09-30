using FastOrder.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastOrder.Domain.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(128);

            builder.HasMany(c => c.Children)
                .WithOne(c => c.Parent)
                .HasForeignKey( c => c.ParentId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade); ;

        }
    }
}
