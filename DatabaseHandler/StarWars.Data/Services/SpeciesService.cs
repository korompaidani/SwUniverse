using AutoMapper;
using StarWars.Data.Entities;
using StarWars.Data.Models.Creatures.Species;
using StarWars.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

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

        public SpeciesOutputModel CreateSpecies(SpeciesCreationModel character)
        {
            throw new NotImplementedException();
        }

        public bool IsSpeciesAlreadyExist(SpeciesCreationModel character)
        {
            throw new NotImplementedException();
        }

        public SpeciesOutputModel GetDefaultSpecies()
        {
            return _mapper.Map<SpeciesOutputModel>(_speciesRepository.GetDefaultSpecies());
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
