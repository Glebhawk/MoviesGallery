using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesGallery.Model;

namespace MoviesGallery.DBContext
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> movies { get; set; }
        public DbSet<Person> persons { get; set; }
        public DbSet<Genre> genres_of_movie { get; set; }
        public DbSet<Actors_of_movie> actors_of_movie { get; set; }
        public DbSet<Writers_of_movie> writers_of_movie { get; set; }

        public MovieContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MoviesDB;Username=postgres;Password=password");
        }
    }
}
