using AutoMapper;
using System;
using System.Text;

namespace StarWars.Data.Profiles
{
    public class CharactersProfile : Profile
    {
        private const string Bby = "BBY ";
        private const string Aby = "ABY ";

        public CharactersProfile()
        {
            CreateMap<Models.Creatures.Character.CharacterCreationModel, Entities.Character>();
            CreateMap<Entities.Character, Models.Creatures.Character.CharacterOutputModel>();
            CreateMap<Models.Creatures.Character.CharacterCreationModel, Models.Creatures.Character.CharacterOutputModel>();
            CreateMap<Entities.LifeTime, Models.Creatures.Character.CharacterOutputModel>()
                .ForMember(charDto => charDto.FullFormOfAge, m => m.MapFrom(lifeTime => CreateFullFormFromAge(lifeTime.BeginDate, lifeTime.EndDate)));

            // Consider how can this solution help on the species related problem which is handled in the controller
            //CreateMap<Models.Creatures.Character.CharacterCreationDto, Models.Creatures.Character.CharacterDto>()
            //    .ForMember(
            //        dest => dest.Name,
            //        opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            //    .ForMember(
            //        dest => dest.Age,
            //        opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
        }

        private string CreateFullFormFromAge(int begin, int end)
        {
            if(begin == end)
            {
                return null;
            }

            StringBuilder beginTimePrefix = new StringBuilder(String.Empty);
            StringBuilder endTimePrefix = new StringBuilder(String.Empty); ;

            if(begin < 0)
            {
                beginTimePrefix.Append(Bby);
            }
            if(begin > 0)
            {
                beginTimePrefix.Append(Aby);
            }

            if (end < 0)
            {
                endTimePrefix.Append(Bby);
            }
            if (end > 0)
            {
                endTimePrefix.Append(Aby);
            }

            return $"{beginTimePrefix.ToString()}{begin} - {endTimePrefix.ToString()}{end}";
        }
    }
}
