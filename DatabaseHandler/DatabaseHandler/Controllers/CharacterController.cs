using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StarWars.Data.Entities;
using StarWars.Data.Models.Creatures.Character;
using StarWars.Data.Services;

namespace DatabaseHandler.Controllers
{
    [ApiController]
    [Route("api/characters")]
    public class CharacterController : ControllerBase
    {
        private readonly IStarWarsRepository _starWarsRepository;
        private readonly IMapper _mapper;

        public CharacterController(IStarWarsRepository starWarsRepository, IMapper mapper)
        {
            _starWarsRepository = starWarsRepository ??
                throw new ArgumentNullException(nameof(starWarsRepository));
            
            _mapper = mapper ??
               throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost(Name = "CreateCharacter")]
        public ActionResult<CharacterDto> CreateCharacter(CharacterCreationDto character)
        {
            _starWarsRepository.DoFakeStaffs();

            if (_starWarsRepository.CharacterExist(character.Name))
            {
                return Conflict($"The character {character.Name} is already exist");
            }

            Species tempSpecies = _starWarsRepository.GetDefaultSpecies();
            if(character.SpeciesName != null)
            {
                if (!_starWarsRepository.SpeciesExist(character.SpeciesName))
                {
                    var species = new Species { Name = character.SpeciesName };
                    _starWarsRepository.AddSpecies(species);
                    _starWarsRepository.Save();
                }
                
                tempSpecies = _starWarsRepository.GetSpecies(character.SpeciesName);
            }

            var tempCharacter = _mapper.Map<Character>(character);
            tempCharacter.Species = tempSpecies;
            tempCharacter.SpeciesName = tempSpecies.Name;
            
            _starWarsRepository.AddCharacter(tempCharacter);
            _starWarsRepository.Save();

            return CreatedAtRoute("GetCharacter",
                           new { characterId = tempCharacter.Id },
                           _mapper.Map<CharacterDto>(tempCharacter));
        }

        [HttpGet("{characterId}", Name = "GetCharacter")]
        [ResponseCache(Duration = 120)]
        public ActionResult<CharacterDto> GetCharacter(Guid characterId)
        {
            var characterFromRepo = _starWarsRepository.GetCharacter(characterId);

            if (characterFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CharacterDto>(characterFromRepo));
        }
    }
}
