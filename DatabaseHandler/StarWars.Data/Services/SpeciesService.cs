using AutoMapper;
using StarWars.Data.Entities;
using StarWars.Data.Models.Creatures.Species;
using StarWars.Data.Repositories;
using System;

namespace StarWars.Data.Services
{
    public class SpeciesService : ISpeciesService
    {
        private readonly ISpeciesRepository _speciesRepository;
        private readonly IMapper _mapper;

        public SpeciesService(ISpeciesRepository characterRepository, IMapper mapper)
        {
            _speciesRepository = characterRepository ??
                throw new ArgumentNullException(nameof(characterRepository));

            _mapper = mapper ??
               throw new ArgumentNullException(nameof(mapper));
        }

        public SpeciesOutputModel CreateSpecies(SpeciesCreationModel species)
        {
            var tempSpecies = _mapper.Map<Species>(species);

            _speciesRepository.CreateSpecies(tempSpecies);

            return _mapper.Map<SpeciesOutputModel>(tempSpecies);
        }

        public bool IsSpeciesAlreadyExist(SpeciesCreationModel species)
        {
            throw new NotImplementedException();
        }

        public SpeciesOutputModel GetSpecies(string speciesName)
        {
            return _mapper.Map<SpeciesOutputModel>(_speciesRepository.GetSpecies(speciesName));
        }

        public SpeciesOutputModel GetOrCreateSpecies(string speciesName)
        {
            if (!_speciesRepository.IsSpeciesExist(speciesName))
            {
                _speciesRepository.CreateSpecies(new Species { Name = speciesName });
            }

            return _mapper.Map<SpeciesOutputModel>(_speciesRepository.GetSpecies(speciesName));
        }
    }
}
