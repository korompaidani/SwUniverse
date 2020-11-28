using AutoMapper;
using Common;
using System;
using System.Text;

namespace StarWars.Data.Profiles
{
    public class CharactersProfile : Profile
    {
        public CharactersProfile()
        {
            CreateMap<Models.Creatures.Character.CharacterCreationModel, Entities.Character>();            
            CreateMap<Models.Creatures.Character.CharacterCreationModel, Models.Creatures.Character.CharacterOutputModel>();
            CreateMap<Entities.Character, Models.Creatures.Character.CharacterOutputModel>()
                .ForMember(charOut => charOut.FullFormOfAge, m => m.MapFrom(character => CreateFullFormFromAge(character)))
                .ForMember(charOut => charOut.Age, m => m.MapFrom(character => CalculateAge(character)));
        }

        private string CreateFullFormFromAge(Entities.Character character)
        {
            if(character.LifeTime == null)
            {
                return null;
            }

            var begin = character.LifeTime.BeginDate;
            var end = character.LifeTime.EndDate;

            StringBuilder beginTimePrefix = new StringBuilder(String.Empty);
            StringBuilder endTimePrefix = new StringBuilder(String.Empty);

            if (begin != null)
            {
                if (begin > 0)
                {
                    beginTimePrefix.Append(SwConstants.Aby);
                }
                if (begin < 0)
                {
                    beginTimePrefix.Append(SwConstants.Bby);
                    begin *= -1;
                }
            }

            if (end != null)
            {
                if (end > 0)
                {
                    endTimePrefix.Append(SwConstants.Aby);
                }
                if (end < 0)
                {
                    endTimePrefix.Append(SwConstants.Bby);
                    end *= -1;
                }
            }

            return $"{beginTimePrefix.ToString()}{begin} - {endTimePrefix.ToString()}{end}";
        }

        private int CalculateAge(Entities.Character character)
        {
            var lifeTime = character.LifeTime;

            if (lifeTime == null)
            {
                return 0;
            }

            if(lifeTime.BeginDate == null)
            {
                return 0;
            }

            if (lifeTime.EndDate == null)
            {
                return 0;
            }

            return (int)lifeTime.EndDate - (int)lifeTime.BeginDate;
        }
    }
}
