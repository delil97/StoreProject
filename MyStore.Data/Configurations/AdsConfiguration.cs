using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyStore.Core.Models;

namespace MyStore.Data.Configurations
{
    public class AdsConfiguration : IEntityTypeConfiguration<Ad>
    {
        public void Configure(EntityTypeBuilder<Ad> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).UseIdentityColumn();

            builder.ToTable("Ads");
        }
    }
}
