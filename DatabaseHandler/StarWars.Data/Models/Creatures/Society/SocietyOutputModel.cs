using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Models.Creatures.Society
{
    public class SocietyOutputModel
    {
        public Guid Id { get; set; }

        [MaxLength(50, ErrorMessage = "The Name shouldn't have more than 50 characters")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
