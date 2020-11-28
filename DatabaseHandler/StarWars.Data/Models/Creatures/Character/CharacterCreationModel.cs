using StarWars.Data.Models.Creatures.Society;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Models.Creatures.Character
{
    public class CharacterCreationModel
    {
        [Required(ErrorMessage = "You should fill out a Name")]
        [MaxLength(50, ErrorMessage = "The Name shouldn't have more than 50 characters")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "The FamilyName shouldn't have more than 50 characters")]
        public string FamilyName { get; set; }

        [MaxLength(50, ErrorMessage = "The GivenName shouldn't have more than 50 characters")]
        public string GivenName { get; set; }

        [MaxLength(50, ErrorMessage = "The SpeciesName shouldn't have more than 50 characters")]
        public string SpeciesName { get; set; }

        public IList<SocietyOutputModel> MemberOf { get; set; }

        public int? BirthDate { get; set; }

        public int? DeathDate { get; set; }

        public bool IsLifeTimeSet => BirthDate != null || DeathDate != null ? true : false;

        public bool IsSpeciesKindSet => SpeciesName != null ? true : false;

        public bool IsMemberOfSet => MemberOf?.Count != 0 ? true : false;
    }
}
