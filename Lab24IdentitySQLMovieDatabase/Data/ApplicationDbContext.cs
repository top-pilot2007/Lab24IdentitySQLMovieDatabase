using System;
using System.Collections.Generic;
using System.Text;
using Lab24IdentitySQLMovieDatabase.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab24IdentitySQLMovieDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CheckedOutMovies> CheckedOutMovies { get; set;}
        //public DbSet<UserLoginInfo> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(m =>
            {
                m.HasKey(k => k.ID);
                //m.HasOne<Movie>().WithMany().HasForeignKey(k => k.);
                
                m.HasData(
                    new Movie { ID = 1, Title = "Afro Samurai", Genre = MovieGenre.Animated, Year = 2007, Actors = "Samuel L. Jackson", Directors = "Fuminori Kizaki", Runtime= 60, Quantity =1},
                    new Movie { ID = 2, Title = "Lion King", Genre = MovieGenre.Animated, Year = 1994, Actors = "Beyonce", Directors = "Walt Disney", Runtime = 70, Quantity = 1 },
                    new Movie { ID = 3, Title = "The Princess and the Frog", Genre = MovieGenre.Animated, Year = 2007, Actors = "Angela Basset", Directors = "Walt Disney", Runtime = 80, Quantity = 1 },
                    new Movie { ID = 4, Title = "Space Jam", Genre = MovieGenre.Animated, Year = 2001, Actors = "Michael Jordan", Directors = "Warner Brothers", Runtime = 90, Quantity = 1 },
                    new Movie { ID = 5, Title = "Osmosis Jones", Genre = MovieGenre.Animated, Year = 2002, Actors = "Chris Rock", Directors = "Dreamwork", Runtime = 100, Quantity = 1 },
                    new Movie { ID = 6, Title = "Shark Tale", Genre = MovieGenre.Animated, Year = 2003, Actors = "Will Smith", Directors = "Dreamwork", Runtime = 110, Quantity = 1 },
                    new Movie { ID = 7, Title = "Madagascar", Genre = MovieGenre.Animated, Year = 2004, Actors = "John Goodman", Directors = "Paramount", Runtime = 120, Quantity = 1 },
                    new Movie { ID = 8, Title = "Shrek", Genre = MovieGenre.Animated, Year = 2005, Actors = "Mike Meyer", Directors = "Dreamwork", Runtime = 130, Quantity = 1 },
                    new Movie { ID = 9, Title = "Afro Samurai Resurection", Genre = MovieGenre.Animated, Year = 2009, Actors = "Samuel L. Jackson", Directors = "Fuminori Kizaki", Runtime = 140, Quantity = 1 },
                    new Movie { ID = 10, Title = "Mulan", Genre = MovieGenre.Animated, Year = 2007, Actors = "Lucy Lu", Directors = "Walt Disney", Runtime = 150, Quantity = 1 },
                    new Movie { ID = 11, Title = "VeggieTales", Genre = MovieGenre.Animated, Year = 2008, Actors = "Larry Cucumber", Directors = "Ameake Owens", Runtime = 60, Quantity = 1 },
                    new Movie { ID = 12, Title = "Malcolm X", Genre = MovieGenre.Drama, Year = 2009, Actors = "Denzel Washington", Directors = "Spike Lee", Runtime = 70, Quantity = 1 },
                    new Movie { ID = 13, Title = "Hidden Figures", Genre = MovieGenre.Drama, Year = 2010, Actors = "Janelle Monet", Directors = "Pharrell Williams", Runtime = 80, Quantity = 1 },
                    new Movie { ID = 14, Title = "Selma", Genre = MovieGenre.Drama, Year = 2011, Actors = "Martin Luther King", Directors = "Oprah Winfrey", Runtime = 90, Quantity = 1 },
                    new Movie { ID = 15, Title = "Forest Gump", Genre = MovieGenre.Drama, Year = 2012, Actors = "Tom Hank", Directors = "Wendy Finerman", Runtime = 100, Quantity = 1 },
                    new Movie { ID = 16, Title = "42", Genre = MovieGenre.Drama, Year = 2013, Actors = "Chadwick Boseman", Directors = "Thomas Tull", Runtime = 110, Quantity = 1 },
                    new Movie { ID = 17, Title = "Glory", Genre = MovieGenre.Drama, Year = 2014, Actors = "Morgan Freeman", Directors = "Matthew Broderick", Runtime = 120, Quantity = 1 },
                    new Movie { ID = 18, Title = "Beasts of No Nation", Genre = MovieGenre.Drama, Year = 2015, Actors = "Idris Alba", Directors = "Why Kids", Runtime = 130, Quantity = 1 },
                    new Movie { ID = 19, Title = "The Color Purple", Genre = MovieGenre.Drama, Year = 2016, Actors = "Whoppi Goldberg", Directors = "Danny Glover", Runtime = 140, Quantity = 1 },
                    new Movie { ID = 20, Title = "Hotel Rwanda", Genre = MovieGenre.Drama, Year = 2017, Actors = "Don Cheadle", Directors = "Needed Change", Runtime = 60, Quantity = 1 },
                    new Movie { ID = 21, Title = "Ray", Genre = MovieGenre.Drama, Year = 2018, Actors = "Jamie Foxx", Directors = "Musical Genius", Runtime = 70, Quantity = 1 },
                    new Movie { ID = 22, Title = "Lord of War", Genre = MovieGenre.Drama, Year = 2019, Actors = "Nicholas Cage", Directors = "Real Life", Runtime = 80, Quantity = 1 },
                    new Movie { ID = 23, Title = "Get Out", Genre = MovieGenre.Horror, Year = 2020, Actors = "Keegan Michael", Directors = "Too Late", Runtime = 90, Quantity = 1 },
                    new Movie { ID = 24, Title = "Blacula", Genre = MovieGenre.Horror, Year = 1990, Actors = "Edie Murphy", Directors = "Chocolate Blood", Runtime = 100, Quantity = 1 },
                    new Movie { ID = 25, Title = "Vampire in Brooklyn", Genre = MovieGenre.Horror, Year = 1999, Actors = "Edie Murphy", Directors = "Place Shelter", Runtime = 110, Quantity = 1 },
                    new Movie { ID = 26, Title = "Candyman", Genre = MovieGenre.Horror, Year = 1991, Actors = "Lamar Odom", Directors = "Ruined Life", Runtime = 120, Quantity = 1 },
                    new Movie { ID = 27, Title = "Tales from the Hood", Genre = MovieGenre.Horror, Year = 1992, Actors = "Ice Cube", Directors = "Great Memories", Runtime = 130, Quantity = 1 },
                    new Movie { ID = 28, Title = "Us", Genre = MovieGenre.Horror, Year = 1993, Actors = "Every One", Directors = "Yearround Tan", Runtime = 140, Quantity = 1 },
                    new Movie { ID = 29, Title = "Purge", Genre = MovieGenre.Horror, Year = 1994, Actors = "Citizen Arest", Directors = "Future Problem", Runtime = 150, Quantity = 1 },
                    new Movie { ID = 30, Title = "Spawn", Genre = MovieGenre.Horror, Year = 1995, Actors = "Samuel L. Jackson", Directors = "Satan Child", Runtime = 45, Quantity = 1 },
                    new Movie { ID = 31, Title = "A Haunted House", Genre = MovieGenre.Horror, Year = 1996, Actors = "Samuel L. Jackson", Directors = "Hot Property", Runtime = 50, Quantity = 1 },
                    new Movie { ID = 32, Title = "Scary Movie", Genre = MovieGenre.Horror, Year = 1997, Actors = "Samuel L. Jackson", Directors = "Waynes Family", Runtime = 55, Quantity = 1 },
                    new Movie { ID = 33, Title = "Coming To America", Genre = MovieGenre.Comedy, Year = 1998, Actors = "Edie Murphy", Directors = "Edie Murphy", Runtime = 60, Quantity = 1 },
                    new Movie { ID = 34, Title = "Planet Earth", Genre = MovieGenre.Documentary, Year = 1999, Actors = "National Geographic", Directors = "Beautiful Nature", Runtime = 65, Quantity = 1 },
                    new Movie { ID = 35, Title = "Crazy Rich Asians", Genre = MovieGenre.Romance, Year = 1980, Actors = "Fresh Boat", Directors = "Living Big", Runtime = 70, Quantity = 1 },
                    new Movie { ID = 36, Title = "The Notebook", Genre = MovieGenre.Romance, Year = 1981, Actors = "Josh Ryan", Directors = "Love Birds", Runtime = 75, Quantity = 1 },
                    new Movie { ID = 37, Title = "Matrix", Genre = MovieGenre.ScienceFiction, Year = 1982, Actors = "Keanau Reeves", Directors = "Coen Brothers", Runtime = 80, Quantity = 1 },
                    new Movie { ID = 38, Title = "Aliens", Genre = MovieGenre.ScienceFiction, Year = 1983, Actors = "Sigorni Weaver", Directors = "Michael Bay", Runtime = 85, Quantity = 1 },
                    new Movie { ID = 39, Title = "Lovecraft Country", Genre = MovieGenre.ScienceFiction, Year = 1984, Actors = "Atticus Latrice", Directors = "Magic Forsome", Runtime = 90, Quantity = 1 },
                    new Movie { ID = 40, Title = "Eurotrip", Genre = MovieGenre.Comedy, Year = 1985, Actors = "Europeans Descent", Directors = "Stay Alive", Runtime = 95, Quantity = 1 },
                    new Movie { ID = 41, Title = "Hellraiser", Genre = MovieGenre.Horror, Year = 1986, Actors = "Kids Caffein", Directors = "Hungry Tired", Runtime = 100, Quantity = 1 },
                    new Movie { ID = 42, Title = "Friday The 13th", Genre = MovieGenre.Horror, Year = 1987, Actors = "Mike Meyer", Directors = "Octoberfest", Runtime = 105, Quantity = 1 },
                    new Movie { ID = 43, Title = "Back To The Future", Genre = MovieGenre.ScienceFiction, Year = 1988, Actors = "Michael Fox", Directors = "Doctor", Runtime = 110, Quantity = 1 });

            });
            modelBuilder.Entity<CheckedOutMovies>(co =>
            {

                co.HasKey(k => k.Id);
                //co.HasOne<Movie>().WithMany().HasForeignKey(k => k.MovieID);
                //co.HasOne<UserLoginInfo>().WithMany().HasForeignKey(k => k.UserId);

                //co.HasOne(m => m.MovieID).WithMany(u => u.UserID).HasForeignKey(k => k.MovieID);
                //co.HasOne(u => u.UserId).WithMany(co => co.UserId).HasForeignKey(k => k.UserID);
                //_ = co.HasData(
                //    new CheckedOutMovies { Id = 1, UserId = "", MovieID = 43, DueDate = 11 / 09 / 2020 });
            });
            
            //modelBuilder.Entity<UserLoginInfo>(u =>
            //{
            //    u.HasKey(k => k.LoginProvider);
            //});


            base.OnModelCreating(modelBuilder);
        }
        //public DbSet<UserLoginInfo> User { get; set; }
        public DbSet<Lab24IdentitySQLMovieDatabase.Models.CheckOut> CheckOut { get; set; }
    }
}
