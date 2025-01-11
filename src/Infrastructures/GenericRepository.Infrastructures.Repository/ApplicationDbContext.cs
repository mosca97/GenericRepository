using GenericRepository.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Infrastructures.Repository;
internal class ApplicationDbContext : DbContext, IApplicationDbContext
{
    protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "DatabeForTest");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerEntity>(entity =>
        {
            entity.HasKey(x => x.Id);
        });
        modelBuilder.Entity<FavouriteEntity>(entity =>
        {
            entity.HasKey(x => x.Id);
        });
    }

    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<FavouriteEntity> Favourites { get; set; }
}
