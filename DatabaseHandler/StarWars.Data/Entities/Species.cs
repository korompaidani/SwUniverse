using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWars.Data.Entities
{
    public class Species
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }

        public Character Character { get; set; }

        public Planet PlanetForNative { get; set; }
    }
}
