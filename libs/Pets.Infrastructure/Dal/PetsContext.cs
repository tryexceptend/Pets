using Microsoft.EntityFrameworkCore;
using Pets.Domain.Entities.Animals;
using Pets.Domain.Entities.Breeds;
using Pets.Domain.Entities.Pets;
using Pets.Domain.Entities.Users;

namespace Pets.Infrastructure.Dal;
public class PetsContext : DbContext
{
    public DbSet<Animal> Animals { get; set; } = null!;
    public DbSet<Breed> Breeds { get; set; } = null!;
    public DbSet<Pet> Pets { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public PetsContext(DbContextOptions<PetsContext> options)
            : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>().HasOne(p => p.User).WithMany(u => u.Pets).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Pet>().HasOne(p => p.Breed).WithMany(b => b.Pets).OnDelete(DeleteBehavior.Cascade);
    }
}
