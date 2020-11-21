using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class CharactersInFilms
    {
        [Key]
        public Guid CharacterId { get; set; }

        [Key]
        public Guid FilmId { get; set; }
    }
}
