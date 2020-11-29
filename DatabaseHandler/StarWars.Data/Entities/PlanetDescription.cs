using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWars.Data.Entities
{
    public class PlanetDescription
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("PlanetId")]
        public Planet Planet { get; set; }

        public Guid PlanetId { get; set; }

    }
}
