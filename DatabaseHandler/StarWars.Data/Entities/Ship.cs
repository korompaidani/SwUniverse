using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class Ship
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ShipName { get; set; }

        public string Kind { get; set; }

        public string Class { get; set; }

        public bool HasHyperSpaceEngine { get; set; }

        public Character CharacterForOwner { get; set; }

        public Character CharacterForFavouriteOwner { get; set; }
    }
}
