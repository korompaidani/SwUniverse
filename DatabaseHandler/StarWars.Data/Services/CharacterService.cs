using AutoMapper;
using StarWars.Data.Entities;
using StarWars.Data.Models.Creatures.Character;
using StarWars.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ISpeciesService _speciesService;
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;

        public CharacterService(ISpeciesService speciesService, ICharacterRepository characterRepository, IMapper mapper)
        {
            _speciesService = speciesService ??
                throw new ArgumentNullException(nameof(speciesService));

            _characterRepository = characterRepository ??
                throw new ArgumentNullException(nameof(characterRepository));

            _mapper = mapper ??
               throw new ArgumentNullException(nameof(mapper));
        }

        public CharacterOutputModel CreateCharacter(CharacterCreationModel character)
        {
            var tempCharacter = _mapper.Map<Character>(character);
            tempCharacter.Species = _mapper.Map<Species>(
                character.IsSpeciesKindSet 
                ? _speciesService.GetOrCreateSpecies(character.Name) : _speciesService.GetDefaultSpecies());
            tempCharacter.SpeciesName = tempCharacter.Species.Name;

            _characterRepository.CreateCharacter(tempCharacter);

            return _mapper.Map<CharacterOutputModel>(tempCharacter);
        }

        public CharacterOutputModel GetCharacter(Guid characterId)
        {
            return _mapper.Map<CharacterOutputModel>(_characterRepository.GetCharacter(characterId));
        }

        public bool IsCharacterAlreadyExist(CharacterCreationModel character)
        {
            return _characterRepository.IsCharacterExist(character.Name);
        }
    }
}
