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
          new Animal { AnimalId = 1, Name = "Cornelious", Photo = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Florida_Box_Turtle_Digon3_re-edited.jpg/440px-Florida_Box_Turtle_Digon3_re-edited.jpg", Type = "turtle", Personality = "stoic", PowerStatus = 75, Age = 123, Gender = "male", LookingForSlave = true },
          new Animal { AnimalId = 2, Name = "Jasper", Photo = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_weight_other/1800x1200_cat_weight_other.jpg?resize=600px:*", Type = "cat", Personality = "mischevious", PowerStatus = 38, Age = 8, Gender = "male", LookingForSlave = true },
          new Animal { AnimalId = 3, Name = "Shiba", Photo = "https://cdn.wallpapersafari.com/37/15/YsU5Ce.jpg", Type = "hamster", Personality = "insightful", PowerStatus = 40, Age = 2, Gender = "female", LookingForSlave = false }
        );
    }
  }
}