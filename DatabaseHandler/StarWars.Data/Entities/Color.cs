using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class Color
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ColorName { get; set; }

        public Character CharacterForHair { get; set; }

        public Character CharacterForEye { get; set; }

        public Character CharacterForSkin { get; set; }
    }
}
