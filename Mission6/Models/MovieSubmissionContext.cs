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
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action/Adventure"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Horror/ Suspense"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Miscellaneous"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Televison"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "VHS"
                }
                );
            //seeding the database
            mb.Entity<SubmitMovie>().HasData(
                new SubmitMovie
                {
                    MovieID = 1,
                    Title = "You've Got Mail",
                    CategoryId=2,
                    Director= "Nora Ephron",
                    ReleaseYear=1998,
                    Rating="PG"
                },
                new SubmitMovie
                {
                    MovieID = 2,
                    Title = "Call Me By Your Name",
                    CategoryId = 3,
                    Director = "Luca Guadagnino",
                    ReleaseYear = 2017,
                    Rating = "R"
                },
                new SubmitMovie
                {
                    MovieID =3,
                    Title = "While You Were Sleeping",
                    CategoryId = 2,
                    Director = "Jon Turteltaub",
                    ReleaseYear = 1995,
                    Rating = "PG"
                }
                );
        }
    }
}
