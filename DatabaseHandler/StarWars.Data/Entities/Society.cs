﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Entities
{
    public class Society
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string History { get; set; }
    }
}
