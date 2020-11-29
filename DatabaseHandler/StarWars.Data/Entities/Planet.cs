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

        public Planet PlanetForMoon { get; set; }

        public bool HasRing { get; set; }
        public bool IsDestroyed { get; set; }

        public Character CharacterForHome { get; set; }

        [MaxLength(1500)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string History { get; set; }

        public string FloraAndFauna { get; set; }

        public string Geography { get; set; }

        public bool IsCrystalSite { get; set; }

        public ICollection<Species> NativeSpecies { get; set; }
            = new List<Species>();
    }
}
