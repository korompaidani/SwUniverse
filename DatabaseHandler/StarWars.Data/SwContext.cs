using Microsoft.EntityFrameworkCore;
using StarWars.Data.Entities;

namespace StarWars.Data
{
    public class SwContext : DbContext
    {
        public SwContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<LifeTime> Lifetimes { get; set; }
    }
}
