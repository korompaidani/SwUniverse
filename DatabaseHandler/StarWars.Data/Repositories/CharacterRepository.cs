using StarWars.Data.DbContexts;
using StarWars.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWars.Data.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly SwContext _context;

        public CharacterRepository(SwContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateCharacter(Character character)
        {
            if(character == null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            character.Id = new Guid();

            _context.Characters.Add(character);

            SaveChanges();
        }        

        public bool IsCharacterExist(Guid characterId)
        {
            if (characterId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(characterId));
            }

            return _context.Characters.Any(c => c.Id == characterId);
        }

        public bool IsCharacterExist(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            return _context.Characters.Any(c => c.Name == name);
        }

        public Character GetCharacter(Guid characterId)
        {
            if (characterId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(characterId));
            }

            return _context.Characters.FirstOrDefault(c => c.Id == characterId);
        }
       
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }              
    }
}
