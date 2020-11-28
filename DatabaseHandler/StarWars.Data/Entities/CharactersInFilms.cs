using System;

namespace StarWars.Data.Entities
{
    public class CharactersInFilms
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }

        public Guid FilmId { get; set; }
        public Film Film { get; set; }
    }
}
