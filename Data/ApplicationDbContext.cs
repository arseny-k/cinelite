using Microsoft.EntityFrameworkCore;
using CineLite.Models;

namespace CineLite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Position> Positions => Set<Position>();
        public DbSet<Actor> Actors => Set<Actor>();
        public DbSet<Repertoire> Repertoires => Set<Repertoire>();
        public DbSet<Seat> Seats => Set<Seat>();
    }
}
