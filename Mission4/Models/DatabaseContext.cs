using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext>options) : base (options)
        {

        }

        public DbSet<AddToDatabase> addedMovies { get; set; }
        public DbSet<Category> Categories { get; set; } 

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
            );

            mb.Entity<AddToDatabase>().HasData(

                new AddToDatabase
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Avengers",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "",
                },
                 new AddToDatabase
                 {
                     MovieId = 2,
                     CategoryId = 1,
                     Title = "The Dark Knight",
                     Year = 2008,
                     Director = "Christopher Nolan",
                     Rating = "PG-13",
                     Edited = false,
                     Lent = "",
                     Notes = "",
                 },
                  new AddToDatabase
                  {
                      MovieId = 3,
                      CategoryId = 1,
                      Title = "Indiana Jones and the Raiders of the Lost Ark",
                      Year = 1981,
                      Director = "Steven Spielberg",
                      Rating = "PG",
                      Edited = false,
                      Lent = "",
                      Notes = "",
                  }

            );
        }
    }
}
