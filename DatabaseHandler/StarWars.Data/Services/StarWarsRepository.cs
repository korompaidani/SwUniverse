using StarWars.Data.DbContexts;
using StarWars.Data.Entities;
using System;
using System.Collections.Generic;
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
    }
}
