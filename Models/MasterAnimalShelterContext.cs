using Microsoft.EntityFrameworkCore;

namespace MasterAnimalShelter.Models
{
  public class MasterAnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public MasterAnimalShelterContext(DbContextOptions<MasterAnimalShelterContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId=1, Name="Cornelious", Type="turtle", Personality="stoic", PowerStatus=75, Age=123, Gender="male", LookingForSlave=true},
            new Animal {AnimalId=2, Name="Jasper", Type="cat", Personality="mischevious", PowerStatus=38, Age=8, Gender="male", LookingForSlave=true},
            new Animal {AnimalId=3, Name="Shiba", Type="hamster", Personality="insightful", PowerStatus=40, Age=2, Gender="female", LookingForSlave=false}
          );
      }
  }
}