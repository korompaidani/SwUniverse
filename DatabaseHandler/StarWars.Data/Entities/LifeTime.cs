using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Entities
{
    [Keyless]
    public class LifeTime
    {
        [Required]
        public Guid Id { get; set; }
        public int BeginDate { get; set; }
        public int EndDate { get; set; }
    }
}
