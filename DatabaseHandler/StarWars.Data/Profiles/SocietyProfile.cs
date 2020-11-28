using AutoMapper;

namespace StarWars.Data.Profiles
{
    public class SocietyProfile : Profile
    {
        public SocietyProfile()
        {
            CreateMap<Models.Creatures.Society.SocietyCreationModel, Entities.Society>();
            CreateMap<Models.Creatures.Society.SocietyCreationModel, Models.Creatures.Society.SocietyOutputModel>();
            CreateMap<Models.Creatures.Society.SocietyOutputModel, Entities.Society>();
            CreateMap<Models.Creatures.Society.SocietyOutputModel, Models.Creatures.Society.SocietyOutputModel>();
            CreateMap<Entities.Society, Models.Creatures.Society.SocietyCreationModel>();
            CreateMap<Entities.Society, Models.Creatures.Society.SocietyOutputModel>();
        }        
    }
}