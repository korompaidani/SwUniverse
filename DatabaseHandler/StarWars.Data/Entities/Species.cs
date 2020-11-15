using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWars.Data.Entities
{
    public class Species
    {
        [Key]
        [MaxLength(15)]
        public string Name { get; set; }
    }
}
