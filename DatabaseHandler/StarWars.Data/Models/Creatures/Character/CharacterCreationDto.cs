using StarWars.Data.Models.Creatures.Species;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Models.Creatures.Character
{
    public class CharacterCreationDto
    {
        [Required(ErrorMessage = "You should fill out a Name")]
        [MaxLength(50, ErrorMessage = "The title shouldn't have more than 50 characters")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "The title shouldn't have more than 50 characters")]
        public string FamilyName { get; set; }

        [MaxLength(50, ErrorMessage = "The title shouldn't have more than 50 characters")]
        public string GivenName { get; set; }

        //public SpeciesCreationDto Species { get; set; }
    }
}
