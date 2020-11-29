using StarWars.Data.Models.Creatures.Species;

namespace StarWars.Data.Services
{
    public interface ISpeciesService
    {
        SpeciesOutputModel CreateSpecies(SpeciesCreationModel species);
        bool IsSpeciesAlreadyExist(SpeciesCreationModel species);
        SpeciesOutputModel GetSpecies(string speciesName);
        SpeciesOutputModel GetOrCreateSpecies(string speciesName);
    }
}
