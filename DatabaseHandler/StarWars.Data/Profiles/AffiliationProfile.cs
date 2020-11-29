using AutoMapper;

namespace StarWars.Data.Profiles
{
    public class AffiliationProfile : Profile
    {
        public AffiliationProfile()
        {
            CreateMap<Models.Creatures.Society.AffiliationCreationModel, Entities.Affiliation>();
            CreateMap<Models.Creatures.Society.AffiliationCreationModel, Models.Creatures.Society.AffiliationOutputModel>();
            CreateMap<Models.Creatures.Society.AffiliationOutputModel, Entities.Affiliation>();
            CreateMap<Models.Creatures.Society.AffiliationOutputModel, Models.Creatures.Society.AffiliationOutputModel>();
            CreateMap<Entities.Affiliation, Models.Creatures.Society.AffiliationCreationModel>();
            CreateMap<Entities.Affiliation, Models.Creatures.Society.AffiliationOutputModel>();
        }        
    }
}