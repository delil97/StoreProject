using Microsoft.EntityFrameworkCore;
using MyStore.Core.Models;
using MyStore.Data.Configurations;

namespace MyStore.Data
{
    public class MyStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        public MyStoreDbContext(DbContextOptions<MyStoreDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new UserConfiguration());

            builder
                .ApplyConfiguration(new AdressConfiguration());
        }
    }
}
