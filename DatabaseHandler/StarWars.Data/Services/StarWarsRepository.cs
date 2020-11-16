using StarWars.Data.DbContexts;
using StarWars.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWars.Data.Services
{
    public class StarWarsRepository : IStarWarsRepository
    {
        /// <summary>
        /// This Guid is necessarry because Guid.Empty is overriden by EF
        /// </summary>
        private const string DefaultSpeciesName = "Unknown";

        private readonly SwContext _context;

        public StarWarsRepository(SwContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddCharacter(Character character)
        {
            if(character == null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            character.Id = new Guid();

            _context.Characters.Add(character);
        }

        public void AddSpecies(Species species)
        {
            if (species == null)
            {
                throw new ArgumentNullException(nameof(species));
            }

            _context.Species.Add(species);
        }

        public bool CharacterExist(Guid characterId)
        {
            if (characterId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(characterId));
            }

            return _context.Characters.Any(c => c.Id == characterId);
        }

        public Character GetCharacter(Guid characterId)
        {
            if (characterId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(characterId));
            }

            return _context.Characters.FirstOrDefault(c => c.Id == characterId);
        }

        public Species GetSpecies(string speciesName)
        {
            if (speciesName == null)
            {
                throw new ArgumentNullException(nameof(speciesName));
            }

            return _context.Species.FirstOrDefault(s => s.Name == speciesName);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public Species GetDefaultSpecies()
        {
            Species tempSpecies = null;
            if (!_context.Species.Any(s => s.Name == DefaultSpeciesName))
            {
                tempSpecies = new Species
                { 
                    Name = DefaultSpeciesName
                };                
                
                _context.Species.Add(tempSpecies);
                Save();
            }

            return _context.Species.FirstOrDefault(s => s.Name == DefaultSpeciesName);
        }

        public bool SpeciesExist(string speciesName)
        {            
            if (speciesName == null)
            {
                throw new ArgumentNullException(nameof(speciesName));
            }

            return _context.Species.Any(s => s.Name == speciesName);
        }

        public bool CharacterExist(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            return _context.Characters.Any(c => c.Name == name);
        }

        public void AddFakePlanet()
        {
            var planet = new Planet
            {
                Id = new Guid("{873957db-073e-47ce-ceef-08d88a6349b9}"),
                Name = "Planet 2",
                Shape = Common.PlanetShape.Sphere,
                Moons = new List<Planet>
                {
                    new Planet{Id = new Guid(), Name = "m1"},
                    new Planet{Id = new Guid(), Name = "m2"}
                }
            };

            var planetDescription = new PlanetDescription
            {
                Planet = planet,
                PlanetId = new Guid("{873957db-073e-47ce-ceef-08d88a6349b9}"),
                ShortDescription = "Short",
                Description = "Full desc",
                NativeSpecies = new List<Species>
                {
                    new Species { Name = "Specc1" },
                    new Species { Name = "s2" },
                    new Species { Name = "3" },
                    new Species { Name = "4" }
                }
            };

            //_context.Planets.Add(planet);
            //Save();

            _context.PlanetDescriptions.Add(planetDescription);
            Save();
        }
    }
}
