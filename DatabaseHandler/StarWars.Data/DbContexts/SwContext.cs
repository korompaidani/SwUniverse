using Microsoft.EntityFrameworkCore;
using StarWars.Data.Entities;

namespace StarWars.Data.DbContexts
{
    public class SwContext : DbContext
    {
        public SwContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharactersInFilms>().HasKey(cf => new { cf.CharacterId, cf.FilmId });
            modelBuilder.Entity<CharactersInSeries>().HasKey(cf => new { cf.CharacterId, cf.SeriesId });
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<LifeTime> Lifetimes { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Society> Society { get; set; }
        public DbSet<PlanetDescription> PlanetDescriptions { get; set; }
        public DbSet<CharactersInFilms> CharactersInFilms { get; set; }
        public DbSet<CharactersInSeries> CharactersInSeries { get; set; }

    }
}
