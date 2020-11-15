using System;

namespace StarWars.Data.Models.Creatures.Character
{
    public class CharacterDto : CharacterCreationDto
    {
        public Guid Id { get; set; }
    }
}
