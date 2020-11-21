using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class CharactersInSeries
    {
        [Key]
        public Guid CharacterId { get; set; }

        [Key]
        public Guid SerieId { get; set; }
    }
}