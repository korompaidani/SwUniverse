using AutoMapper;

namespace StarWars.Data.Profiles
{
    public class LifeTimeProfile : Profile
    {
        public LifeTimeProfile()
        {
            CreateMap<Models.LifeTimeCreationModel, Entities.LifeTime>();
            CreateMap<Models.LifeTimeCreationModel, Models.LifeTimeOutputModel>();
            CreateMap<Models.LifeTimeOutputModel, Entities.Society>();
            CreateMap<Models.LifeTimeOutputModel, Models.LifeTimeCreationModel>();
            CreateMap<Entities.Society, Models.LifeTimeCreationModel>();
            CreateMap<Entities.Society, Models.LifeTimeOutputModel>();
        }
    }
}
