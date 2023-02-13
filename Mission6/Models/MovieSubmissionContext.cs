using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class MovieSubmissionContext : DbContext
    {
        //Constructor
        public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext> options) : base(options)
        {
            //leaving blank for now
        }

        public DbSet<SubmitMovie> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<SubmitMovie>().HasData(
                new SubmitMovie
                {
                    MovieID = 1,
                    Title = "You've Got Mail",
                    Category="Romantic Comedy",
                    Director= "Nora Ephron",
                    ReleaseYear=1998,
                    Rating="PG"
                },
                new SubmitMovie
                {
                    MovieID = 2,
                    Title = "Call Me By Your Name",
                    Category = "Drama",
                    Director = "Luca Guadagnino",
                    ReleaseYear = 2017,
                    Rating = "R"
                },
                new SubmitMovie
                {
                    MovieID =3,
                    Title = "While You Were Sleeping",
                    Category = "Romantic Comedy",
                    Director = "Jon Turteltaub",
                    ReleaseYear = 1995,
                    Rating = "PG"
                }
                );
        }
    }
}
