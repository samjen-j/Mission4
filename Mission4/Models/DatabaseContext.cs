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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddToDatabase>().HasData(

                new AddToDatabase
                {
                    ApplicationId = 1,
                    Category = "Action/Adventure",
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
                     ApplicationId = 2,
                     Category = "Action/Adventure",
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
                      ApplicationId = 3,
                      Category = "Action/Adventure",
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
