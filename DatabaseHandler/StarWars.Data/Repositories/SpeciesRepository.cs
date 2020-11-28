using StarWars.Data.DbContexts;
using StarWars.Data.Entities;
using System;
using System.Linq;

namespace StarWars.Data.Repositories
{
    public class SpeciesRepository : ISpeciesRepository
    {
        private const string DefaultSpeciesName = "Unknown";
        private readonly SwContext _context;

        public bool HasDefaultSpecies { get; }

        public SpeciesRepository(SwContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            CreateDefaultSpeciesIfNecessary();
        }

        public void CreateSpecies(Species species)
        {
            if (species == null)
            {
                throw new ArgumentNullException(nameof(species));
            }

            _context.Species.Add(species);

            SaveChanges();
        }

        public Species GetDefaultSpecies()
        {
            return _context.Species.FirstOrDefault(s => s.Name == DefaultSpeciesName);
        }

        public Species GetSpecies(string speciesName)
        {
            if (speciesName == null)
            {
                throw new ArgumentNullException(nameof(speciesName));
            }

            return _context.Species.FirstOrDefault(s => s.Name == speciesName);
        }

        public bool IsSpeciesExist(string speciesName)
        {
            if (speciesName == null)
            {
                throw new ArgumentNullException(nameof(speciesName));
            }

            return _context.Species.Any(s => s.Name == speciesName);
        }

        private void CreateDefaultSpeciesIfNecessary() 
        {
            Species tempSpecies = null;
            if (!_context.Species.Any(s => s.Name == DefaultSpeciesName))
            {
                tempSpecies = new Species
                {
                    Name = DefaultSpeciesName
                };

                _context.Species.Add(tempSpecies);

                SaveChanges();
            }
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
