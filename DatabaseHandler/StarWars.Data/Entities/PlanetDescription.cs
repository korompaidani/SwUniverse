using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWars.Data.Entities
{
    [Keyless]
    public class PlanetDescription
    {
        [ForeignKey("PlanetId")]
        public Planet Planet { get; set; }

        public Guid PlanetId { get; set; }

        [MaxLength(1500)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string History { get; set; }

        public string Geography { get; set; }

        //public ICollection<Species> NativeSpecies { get; set; }
        //    = new List<Species>();
    }
}
