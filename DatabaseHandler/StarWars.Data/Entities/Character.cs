using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWars.Data.Entities
{
    public class Character
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string GivenName { get; set; }

        [MaxLength(50)]
        public string FamilyName { get; set; }

        [ForeignKey("SpeciesName")]
        public Species Species { get; set; }

        public string SpeciesName { get; set; }

        [ForeignKey("LifeTimeId")]
        public LifeTime LifeTime { get; set; }

        public Guid? LifeTimeId { get; set; }

        public ICollection<Affiliation> MemberOf { get; set; }
            = new List<Affiliation>();

        public ICollection<CharactersInFilms> CharactersInFilms { get; set; }
            = new List<CharactersInFilms>();

        public ICollection<CharactersInSeries> CharactersInSeries { get; set; }
            = new List<CharactersInSeries>();
    }
}
