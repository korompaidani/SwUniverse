using StarWars.Data.Entities;
using System;

namespace StarWars.Data.Repositories
{
    public interface ICharacterRepository : IRepository
    {
        void CreateCharacter(Character character);

        Character GetCharacter(Guid characterId);

        bool IsCharacterExist(Guid characterId);

        bool IsCharacterExist(string name);
    }
}
