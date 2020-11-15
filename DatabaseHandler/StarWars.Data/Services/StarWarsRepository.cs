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
        private const string DefaultNullGuidValue = "{11111111-1111-1111-1111-111111111111}";

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

            species.Id = new Guid();

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
            var controlGuid = new Guid(DefaultNullGuidValue);
            Species tempSpecies = null;
            if (!_context.Species.Any(s => s.Id == controlGuid))
            {
                tempSpecies = new Species
                { 
                    Id = controlGuid,
                    Name = String.Empty
                };                
                
                _context.Species.Add(tempSpecies);
                Save();
            }

            return _context.Species.FirstOrDefault(s => s.Id == controlGuid);
        }

        public bool SpeciesExist(string speciesName)
        {            
            if (speciesName == null)
            {
                throw new ArgumentNullException(nameof(speciesName));
            }

            return _context.Species.Any(s => s.Name == speciesName);
        }
    }
}
