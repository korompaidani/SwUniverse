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
    }
}
