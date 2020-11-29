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
            //ManyToMany
            modelBuilder.Entity<CharactersInFilms>().HasKey(cf => new { cf.CharacterId, cf.FilmId });
            modelBuilder.Entity<CharactersInSeries>().HasKey(cf => new { cf.CharacterId, cf.SeriesId });

            //OneToOne
            modelBuilder.Entity<Species>().HasOne(a => a.Character).WithOne(b => b.Species).HasForeignKey<Character>(b => b.SpeciesName);
            modelBuilder.Entity<LifeTime>().HasOne(a => a.Character).WithOne(b => b.LifeTime).HasForeignKey<Character>(b => b.LifeTimeId);
            modelBuilder.Entity<Gender>().HasOne(a => a.Character).WithOne(b => b.Gender).HasForeignKey<Character>(b => b.GenderId);
            modelBuilder.Entity<Color>().HasOne(a => a.CharacterForHair).WithOne(b => b.HairColor).HasForeignKey<Character>(b => b.HairColorId);
            modelBuilder.Entity<Color>().HasOne(a => a.CharacterForEye).WithOne(b => b.EyeColor).HasForeignKey<Character>(b => b.EyeColorId);
            modelBuilder.Entity<Color>().HasOne(a => a.CharacterForSkin).WithOne(b => b.SkinColor).HasForeignKey<Character>(b => b.SkinColorId);
            modelBuilder.Entity<Planet>().HasOne(a => a.CharacterForHome).WithOne(b => b.HomeWorld).HasForeignKey<Character>(b => b.HomeWorldId);
            modelBuilder.Entity<Weapon>().HasOne(a => a.CharacterForFavouriteOwner).WithOne(b => b.FavouriteWeapon).HasForeignKey<Character>(b => b.FavouriteWeaponId);
            modelBuilder.Entity<Ship>().HasOne(a => a.CharacterForFavouriteOwner).WithOne(b => b.FavouriteShip).HasForeignKey<Character>(b => b.FavouriteShipId);

            //OneToMany
            modelBuilder.Entity<Affiliation>().HasOne(s => s.CharacterAsMember).WithMany(c => c.MemberOf);
            modelBuilder.Entity<Weapon>().HasOne(s => s.CharacterForOwner).WithMany(c => c.Weapons);
            modelBuilder.Entity<Ship>().HasOne(s => s.CharacterForOwner).WithMany(c => c.Ships);
            modelBuilder.Entity<Character>().HasOne(s => s.CharacterForApprentice).WithMany(c => c.Apprentices);
            modelBuilder.Entity<Character>().HasOne(s => s.CharacterForMaster).WithMany(c => c.Masters);

            modelBuilder.Entity<Planet>().HasOne(s => s.PlanetForMoon).WithMany(c => c.Moons);
            modelBuilder.Entity<Species>().HasOne(s => s.PlanetForNative).WithMany(c => c.NativeSpecies);
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<LifeTime> Lifetimes { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Affiliation> Affiliations { get; set; }
        public DbSet<PlanetDescription> PlanetDescriptions { get; set; }
        public DbSet<CharactersInFilms> CharactersInFilms { get; set; }
        public DbSet<CharactersInSeries> CharactersInSeries { get; set; }

    }
}
