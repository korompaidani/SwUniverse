using StarWars.Data.Models.Creatures.Society;
using System;

namespace StarWars.Data.Services
{
    public interface IAffiliationService
    {
        AffiliationOutputModel CreateAffiliation(AffiliationCreationModel affiliation);
        bool IsAffiliationAlreadyExist(AffiliationCreationModel affiliation);
        AffiliationOutputModel GetAffiliation(string affiliationName);
        AffiliationOutputModel GetAffiliation(Guid affiliationId);
        AffiliationOutputModel GetOrCreateAffiliation(string affiliationName);
    }
}