using AutoMapper;
using StarWars.Data.Entities;
using StarWars.Data.Models.Creatures.Character;
using StarWars.Data.Repositories;
using System;

namespace StarWars.Data.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ISpeciesService _speciesService;
        private readonly ISocietyService _societyService;
        private readonly ILifeTimeService _lifeTimeService;

        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;

        public CharacterService(
            ISpeciesService speciesService, 
            ISocietyService societyService, 
            ILifeTimeService lifeTimeService, 
            ICharacterRepository characterRepository, 
            IMapper mapper)
        {
            _speciesService = speciesService ??
                throw new ArgumentNullException(nameof(speciesService));

            _societyService = societyService ??
                throw new ArgumentNullException(nameof(societyService));

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
            AddSocietiesToCharacterIfSet(character, ref tempCharacter);

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
            var tempSpecies = character.IsSpeciesKindSet ? _speciesService.GetOrCreateSpecies(character.SpeciesName) : _speciesService.GetDefaultSpecies();
            outCharacter.SpeciesName = tempSpecies.Name;
        }

        private void AddSocietiesToCharacterIfSet(CharacterCreationModel character, ref Character outCharacter)
        {
            if (character.IsMemberOfSet)
            {
                foreach (var society in character.MemberOf)
                {
                    _societyService.GetOrCreateSociety(society.Name);
                }
            }
        }
    }
}
