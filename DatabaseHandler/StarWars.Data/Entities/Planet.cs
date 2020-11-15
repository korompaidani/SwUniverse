using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Entities
{
    public class Planet
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public PlanetShape Shape { get; set; }
        public ICollection<Planet> Moons { get; set; }
            = new List<Planet>();

        public bool HasRing { get; set; }
        public bool IsDestroyed { get; set; }
    }
}
