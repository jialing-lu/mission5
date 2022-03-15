using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This is the DBcontext class to setup connection beetween DB and this program

namespace DateMe.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
            //Leave blank for now 
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<category> Categories { get; set; }
 
        //Seeding Data 

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<category>().HasData(
                new category { CategoryId = 1, Category = "Romance"},
                new category { CategoryId = 2, Category = "War"},
                new category { CategoryId = 3, Category = "Crime" }
                );

            mb.Entity<ApplicationResponse>().HasData(
                // seeding the DB with my three farovite movies: 

                new ApplicationResponse
                {
                    MovieId = 1, 
                    CategoryId = 1,
                    Title = "Love Actually",
                    Year = 2003,
                    DirectorFirstName = "Richard",
                    DirectorLastName = "Curtis",
                    Rating = "R",
                    Edited = true,
                    LentTo = "",
                    Notes = "Merry Christmas!"
                },

                new ApplicationResponse
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "Kingdom of Heaven",
                    Year = 2005,
                    DirectorFirstName = "Ridley",
                    DirectorLastName = "Scott",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = "MUST: Director's Cut"
                },

                new ApplicationResponse
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "New World",
                    Year = 2013,
                    DirectorFirstName = "Hoon-jung",
                    DirectorLastName = "Park",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = "BEST EVER"
                }
             );
        }
    }
}
