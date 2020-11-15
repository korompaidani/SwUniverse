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

            // Consider how can this solution help on the species related problem which is handled in the controller
            //CreateMap<Entities.Author, Models.AuthorDto>()
            //    .ForMember(
            //        dest => dest.Name,
            //        opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            //    .ForMember(
            //        dest => dest.Age,
            //        opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
        }
    }
}
