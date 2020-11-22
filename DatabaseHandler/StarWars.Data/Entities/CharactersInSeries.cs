using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class CharactersInSeries
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }

        public Guid SeriesId { get; set; }
        public Series Series { get; set; }
    }
}