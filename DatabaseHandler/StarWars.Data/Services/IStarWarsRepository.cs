using StarWars.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Services
{
    public interface IStarWarsRepository
    {
        void AddCharacter(Character character);

        Character GetCharacter(Guid characterId);

        bool CharacterExist(Guid characterId);
    }
}
