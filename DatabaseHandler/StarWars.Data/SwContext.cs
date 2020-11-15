using Microsoft.EntityFrameworkCore;
using StarWars.Data.Models;

namespace StarWars.Data
{
    public class SwContext : DbContext
    {
        public SwContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SwCharacter> Characters { get; set; }
        public DbSet<SwEvent> Events { get; set; }
        public DbSet<SwLifeTime> Lifetimes { get; set; }
    }
}
