using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class Weapon
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string WeaponName { get; set; }

        public Character CharacterForOwner { get; set; }

        public Character CharacterForFavouriteOwner { get; set; }
    }
}
