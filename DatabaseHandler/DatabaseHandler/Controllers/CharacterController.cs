using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public CharacterController(IStarWarsRepository starWarsRepository)
        {
            _starWarsRepository = starWarsRepository ??
                throw new ArgumentNullException(nameof(starWarsRepository));
        }

        [HttpPost(Name = "CreateCharacter")]
        public ActionResult<CharacterDto> CreateCharacter(CharacterCreationDto character)
        {
            Species tempSpecies = _starWarsRepository.GetNullSpecies();
            if(character.SpeciesName != null)
            {
                if (!_starWarsRepository.SpeciesExist(character.Name))
                {
                    var species = new Species { Name = character.SpeciesName };
                    _starWarsRepository.AddSpecies(species);
                    _starWarsRepository.Save(); //?
                }
                
                tempSpecies = _starWarsRepository.GetSpecies(character.SpeciesName);
            }

            var tempCharacter = new Character {
                Name = character.Name,
                FamilyName = character.FamilyName,
                GivenName = character.GivenName,
                Species = tempSpecies,
                SpeciesId = tempSpecies.Id
            };

            _starWarsRepository.AddCharacter(tempCharacter);
            _starWarsRepository.Save();

            var resultCharacterDto = new CharacterDto
            {
                Id = tempCharacter.Id,
                Name = tempCharacter.Name,
                FamilyName = tempCharacter.FamilyName,
                GivenName = tempCharacter.GivenName,
                SpeciesName = tempCharacter.Species.Name
            };

            return CreatedAtRoute("GetCharacter",
                           new { characterId = tempCharacter.Id },
                           resultCharacterDto);
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

            var resultCharacterDto = new CharacterDto
            {
                Id = characterFromRepo.Id,
                Name = characterFromRepo.Name,
                FamilyName = characterFromRepo.Name,
                GivenName = characterFromRepo.Name
            };

            return Ok(resultCharacterDto);
        }
    }
}
