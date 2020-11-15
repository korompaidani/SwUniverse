using System;
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
        public string FamilyName { get; set; }

        [MaxLength(50)]
        public string GivenName { get; set; }

        //[ForeignKey("SpeciesId")]
        //public Species Species { get; set; }

        //public Guid SpeciesId { get; set; }
    }
}
