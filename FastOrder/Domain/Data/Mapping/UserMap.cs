using FastOrder.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastOrder.Domain.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User_");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Username)
                .IsRequired(true)
                .HasMaxLength(32)
                .HasColumnType("VARCHAR(32)");

            builder.HasIndex(x => x.Email)
               .IsUnique(true);
        }
    }
}
