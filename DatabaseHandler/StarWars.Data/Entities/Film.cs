using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class Film
    {
        [Key]
        public Guid Id { get; set; }

        public ICollection<CharactersInFilms> CharactersInFilms { get; set; }
    }
}
