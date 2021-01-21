using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
    public class TravelAPIContext : DbContext
    {
        public TravelAPIContext(DbContextOptions<TravelAPIContext> options):base(options)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Packlist> Packlists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>()
                .HasData(
                    new City { CityId = 1, Name = "Renton", Attraction = "Boeing", Rating = 9, Review = "has nice hot tubs"},
                    new City {CityId = 2, Name ="Portland", Attraction = "Powells", Rating = 8, Review= "This city is pretty cool, rains a lot though"},
                    new City { CityId = 3, Name = "Philadelphia", Attraction = "Magic Gardens", Rating = 8, Review = "I hear there is lots of brotherly love here"},
                    new City { CityId = 4, Name = "Boston", Attraction = "North Eastern University", Rating = 1, Review = "has nice shrubs"}
                );
        }
    }
}