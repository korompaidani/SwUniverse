using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Profiles
{
    public class CharactersProfile : Profile
    {
        public CharactersProfile()
        {
            CreateMap<Models.Creatures.Character.CharacterCreationDto, Entities.Character>();
            CreateMap<Entities.Character, Models.Creatures.Character.CharacterDto>();
        }
    }
}
