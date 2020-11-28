using System;
using Microsoft.AspNetCore.Mvc;
using StarWars.Data.Models.Creatures.Character;
using StarWars.Data.Services;

namespace DatabaseHandler.Controllers
{
    [ApiController]
    [Route("api/characters")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService ??
                throw new ArgumentNullException(nameof(characterService));
        }

        [HttpPost(Name = "CreateCharacter")]
        public ActionResult<CharacterOutputModel> CreateCharacter(CharacterCreationModel character)
        {
            if (_characterService.IsCharacterAlreadyExist(character))
            {
                return Conflict($"The character {character.Name} is already exist");
            }

            var returnCharacter = _characterService.CreateCharacter(character);

            return CreatedAtRoute("GetCharacter",
                           new { characterId = returnCharacter.Id },
                           returnCharacter);
        }

        [HttpGet("{characterId}", Name = "GetCharacter")]
        [ResponseCache(Duration = 120)]
        public ActionResult<CharacterOutputModel> GetCharacter(Guid characterId)
        {
            var returnCharacter = _characterService.GetCharacter(characterId);

            if (returnCharacter == null)
            {
                return NotFound();
            }

            return Ok(returnCharacter);
        }
    }
}
