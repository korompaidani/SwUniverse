using StarWars.Data.Models.Creatures.Species;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Services
{
    public interface ISpeciesService
    {
        SpeciesOutputModel CreateSpecies(SpeciesCreationModel character);
        bool IsSpeciesAlreadyExist(SpeciesCreationModel character);
        SpeciesOutputModel GetDefaultSpecies();
        SpeciesOutputModel GetSpecies(string speciesName);
        SpeciesOutputModel GetOrCreateSpecies(string speciesName);
    }
}
