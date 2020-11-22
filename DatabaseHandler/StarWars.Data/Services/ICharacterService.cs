using StarWars.Data.Models.Creatures.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Services
{
    public interface ICharacterService
    {
        CharacterOutputModel CreateCharacter(CharacterCreationModel character);
        bool IsCharacterAlreadyExist(CharacterCreationModel character);
        CharacterOutputModel GetCharacter(Guid characterId);

    }
}
