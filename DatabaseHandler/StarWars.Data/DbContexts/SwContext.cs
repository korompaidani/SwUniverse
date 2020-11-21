using Microsoft.EntityFrameworkCore;
using StarWars.Data.Entities;

namespace StarWars.Data.DbContexts
{
    public class SwContext : DbContext
    {
        public SwContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<LifeTime> Lifetimes { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Society> Societies { get; set; }
        public DbSet<PlanetDescription> PlanetDescriptions { get; set; }
    }
}
