namespace Planty.Data.Context
{
    using Microsoft.EntityFrameworkCore;
    using Planty.Common.Extensions;
    using Planty.Data.Entities;
    using Planty.Data.Interfaces;

    public class DatabaseContext : DbContext, IReadOnlyDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ValidateIsNotNull(nameof(modelBuilder));

            modelBuilder.Entity<Product>()
                .Property(e => e.Price).HasColumnType("decimal(18,2)");
        }
    }
}
