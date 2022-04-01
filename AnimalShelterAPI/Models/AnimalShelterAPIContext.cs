using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public AnimalShelterAPIContext (DbContextOptions<AnimalShelterAPIContext> options) : base(options)
    {
    }
    public DbSet<Animal> Animals {get;set;}
    protected override void OnModelCreating(ModelBuilder builder)
    {
    builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Matilda", Species = "Dog", Age = 7, Gender = "Female" },
        new Animal { AnimalId = 2, Name = "Rexie", Species = "Cat", Age = 10, Gender = "Female" },
        new Animal { AnimalId = 3, Name = "Matilda", Species = "Dog", Age = 2, Gender = "Female" },
        new Animal { AnimalId = 4, Name = "Pip", Species = "Cat", Age = 4, Gender = "Male" },
        new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Bunny", Age = 22, Gender = "Male" }
      );
    }
  }
}