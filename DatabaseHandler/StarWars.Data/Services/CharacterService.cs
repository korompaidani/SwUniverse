using AutoMapper;
using StarWars.Data.Entities;
using StarWars.Data.Models;
using StarWars.Data.Models.Creatures.Character;
using StarWars.Data.Repositories;
using System;

namespace StarWars.Data.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ISpeciesService _speciesService;
        private readonly IAffiliationService _affiliationService;
        private readonly ILifeTimeService _lifeTimeService;

        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;

        public CharacterService(
            ISpeciesService speciesService, 
            IAffiliationService affiliationService, 
            ILifeTimeService lifeTimeService, 
            ICharacterRepository characterRepository, 
            IMapper mapper)
        {
            _speciesService = speciesService ??
                throw new ArgumentNullException(nameof(speciesService));

            _affiliationService = affiliationService ??
                throw new ArgumentNullException(nameof(affiliationService));

            _lifeTimeService = lifeTimeService ??
                throw new ArgumentNullException(nameof(lifeTimeService));

            _characterRepository = characterRepository ??
                throw new ArgumentNullException(nameof(characterRepository));

            _mapper = mapper ??
               throw new ArgumentNullException(nameof(mapper));
        }

        public CharacterOutputModel CreateCharacter(CharacterCreationModel character)
        {
            var tempCharacter = _mapper.Map<Character>(character);

            AddSpeciesToCharacterIfSet(character, ref tempCharacter);
            AddLifeTimeToCharacterIfSet(character, ref tempCharacter);

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

        private void AddSpeciesToCharacterIfSet(CharacterCreationModel character, ref Character outCharacter)
        {
            var tempSpecies = character.IsSpeciesKindSet ? 
                _speciesService.GetOrCreateSpecies(character.SpeciesName) : null;

            if (tempSpecies != null)
            {
                outCharacter.SpeciesId = tempSpecies.Id;
            }
        }

        private void AddLifeTimeToCharacterIfSet(CharacterCreationModel character, ref Character outCharacter)
        {
            var tempLifeTime = character.IsLifeTimeSet ? 
                _lifeTimeService.CreateLifeTime(
                new LifeTimeCreationModel { BeginDate = character.BirthDate, EndDate = character.DeathDate }) : null;

            if(tempLifeTime != null)
            {
                outCharacter.LifeTimeId = tempLifeTime.Id;
            }
        }
    }
}
