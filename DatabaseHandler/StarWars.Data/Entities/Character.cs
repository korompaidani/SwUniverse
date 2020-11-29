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

        [ForeignKey("HairColorId")]
        public Color HairColor { get; set; }

        public Guid? HairColorId { get; set; }

        [ForeignKey("EyeColorId")]
        public Color EyeColor { get; set; }

        public Guid? EyeColorId { get; set; }

        [ForeignKey("SkinColorId")]
        public Color SkinColor { get; set; }

        public Guid? SkinColorId { get; set; }

        public string SkinPattern { get; set; }

        public bool HasTattoo { get; set; }

        public string Specialrecognizance { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }

        public Guid? GenderId { get; set; }

        [ForeignKey("HomeWorldId")]
        public Planet HomeWorld { get; set; }

        public Guid? HomeWorldId { get; set; }

        [ForeignKey("SpeciesName")]
        public Species Species { get; set; }

        public string SpeciesName { get; set; }

        [ForeignKey("LifeTimeId")]
        public LifeTime LifeTime { get; set; }

        public Guid? LifeTimeId { get; set; }

        public ICollection<Affiliation> MemberOf { get; set; }
            = new List<Affiliation>();

        public ICollection<Weapon> Weapons { get; set; }
            = new List<Weapon>();

        [ForeignKey("FavouriteWeaponId")]
        public Weapon FavouriteWeapon { get; set; }

        public Guid? FavouriteWeaponId { get; set; }

        public ICollection<Ship> Ships { get; set; }
            = new List<Ship>();

        [ForeignKey("FavouriteShipId")]
        public Ship FavouriteShip { get; set; }

        public Guid? FavouriteShipId { get; set; }

        public ICollection<Character> Apprentices { get; set; }
            = new List<Character>();

        public Character CharacterForApprentice { get; set; }

        public ICollection<Character> Masters { get; set; }
            = new List<Character>();

        public Character CharacterForMaster { get; set; }

        public ICollection<CharactersInFilms> CharactersInFilms { get; set; }
            = new List<CharactersInFilms>();

        public ICollection<CharactersInSeries> CharactersInSeries { get; set; }
            = new List<CharactersInSeries>();
    }
}
