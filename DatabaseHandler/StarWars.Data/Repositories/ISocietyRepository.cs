using StarWars.Data.Entities;
using System;

namespace StarWars.Data.Repositories
{
    public interface ISocietyRepository : IRepository
    {
        void CreateSociety(Society society);
        bool IsSocietyExist(Guid societyId);
        Society GetSociety(Guid societyId);
        Society GetSociety(string societyName);
    }
}
