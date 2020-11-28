using StarWars.Data.Models.Creatures.Society;
using System;

namespace StarWars.Data.Services
{
    public interface ISocietyService
    {
        SocietyOutputModel CreateSociety(SocietyCreationModel society);
        bool IsSocietyAlreadyExist(SocietyCreationModel society);
        SocietyOutputModel GetSociety(string societyName);
        SocietyOutputModel GetSociety(Guid societyId);
        SocietyOutputModel GetOrCreateSociety(string societyName);
    }
}