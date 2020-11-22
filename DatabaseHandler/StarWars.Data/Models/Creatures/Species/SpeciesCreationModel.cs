using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Models.Creatures.Species
{
    public class SpeciesCreationModel
    {
        [MaxLength(15, ErrorMessage = "The Name shouldn't have more than 15 characters")]
        public string Name { get; set; }
    }
}
