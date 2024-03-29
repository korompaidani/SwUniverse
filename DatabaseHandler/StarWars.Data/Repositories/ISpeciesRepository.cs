﻿using StarWars.Data.Entities;

namespace StarWars.Data.Repositories
{
    public interface ISpeciesRepository : IRepository
    {
        bool IsSpeciesExist(string speciesName);

        void CreateSpecies(Species species);

        Species GetSpecies(string speciesName);
    }
}
