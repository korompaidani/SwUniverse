using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Models.Creatures.Character
{
    public class CharacterOutputModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "You should fill out a Name")]
        [MaxLength(50, ErrorMessage = "The Name shouldn't have more than 50 characters")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "The FamilyName shouldn't have more than 50 characters")]
        public string FamilyName { get; set; }

        [MaxLength(50, ErrorMessage = "The GivenName shouldn't have more than 50 characters")]
        public string GivenName { get; set; }

        [MaxLength(50, ErrorMessage = "The SpeciesName shouldn't have more than 50 characters")]
        public string SpeciesName { get; set; }
        
        public int Age { get; set; }

        public string FullFormOfAge { get; set; }
    }
}
