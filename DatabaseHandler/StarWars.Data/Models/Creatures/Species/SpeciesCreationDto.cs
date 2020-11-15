using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Models.Creatures.Species
{
    public class SpeciesCreationDto
    {
        [MaxLength(50, ErrorMessage = "The Name shouldn't have more than 50 characters")]
        public string Name { get; set; }
    }
}
