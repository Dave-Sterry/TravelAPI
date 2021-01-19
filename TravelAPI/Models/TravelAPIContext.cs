using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
    public class TravelAPIContext : DbContext
    {
        public TravelAPIContext(DbContextOptions<TravelAPIContext> options):base(options)
        {
        }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>()
                .HasData(
                    new City { CityId = 1, Name = "Renton", Attraction = "Boeing", Rating = 9},
                    new City {CityId = 2, Name ="Portland", Attraction = "Powells", Rating = 8},
                    new City { CityId = 3, Name = "Philadelphia", Attraction = "Magic Gardens", Rating = 8},
                    new City { CityId = 4, Name = "Boston", Attraction = "North Eastern University", Rating = 1}
                );
        }
    }
}