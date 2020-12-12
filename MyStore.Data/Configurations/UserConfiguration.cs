using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyStore.Core.Models;

namespace MyStore.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).UseIdentityColumn();

            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);

            builder.Property(u => u.Password).IsRequired().HasMaxLength(50);

            builder.HasOne(u => u.Adress);

            builder.ToTable("Users");
        }
    }
}
