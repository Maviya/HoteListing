
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Data
{
    public class HoteListingDBContext : DbContext
    {
        public HoteListingDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "America",
                    ShortName = "US"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(

                new Hotel
                {
                    Id = 1,
                    Name = "Centurion",
                    CountryId = 1,
                    Address = "India Pune"
                }

                );
            ;
        }
    }
}
