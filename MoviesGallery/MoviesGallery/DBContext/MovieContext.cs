using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesGallery.EntityModel;

namespace MoviesGallery.DBContext
{
    public class MovieContext : DbContext
    {
        public DbSet<MovieEntity> movies { get; set; }
        public DbSet<PersonEntity> persons { get; set; }
        public DbSet<Genre> genresOfMovie { get; set; }
        public DbSet<ActorOfMovie> actorsOfMovie { get; set; }
        public DbSet<WriterOfMovie> writersOfMovie { get; set; }

        public MovieContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieEntity>().HasMany(m => m.genresOfMovie).WithOne().HasForeignKey("Movieid");

            modelBuilder.Entity<ActorOfMovie>().ToTable("actors_of_movie");
            modelBuilder.Entity<ActorOfMovie>().HasOne(a => a.actor).WithMany().HasForeignKey("actorid");

            modelBuilder.Entity<MovieEntity>().HasMany(m => m.actorsOfMovie).WithOne().HasForeignKey("movieid");
            modelBuilder.Entity<MovieEntity>().HasMany(m => m.writersOfMovie).WithOne().HasForeignKey("movieid");

            modelBuilder.Entity<Genre>().ToTable("genres_of_movie");

            modelBuilder.Entity<MovieEntity>().Property(m => m.posterLink).HasColumnName("poster_link");

            modelBuilder.Entity<WriterOfMovie>().ToTable("writers_of_movie");
            modelBuilder.Entity<WriterOfMovie>().HasOne(w => w.writer).WithMany().HasForeignKey("writerid");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MoviesDB;Username=postgres;Password=password");
        }
    }
}
