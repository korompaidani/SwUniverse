using StarWars.Data.Entities;
using System;

namespace StarWars.Data.Repositories
{
    public interface IAffiliationRepository : IRepository
    {
        void CreateAffiliation(Affiliation affiliation);
        bool IsAffiliationExist(string affiliationName);
        Affiliation GetAffiliation(Guid affiliationId);
        Affiliation GetAffiliation(string affiliationName);
    }
}
