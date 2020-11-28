using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Entities
{
    public class LifeTime
    {
        [Key]
        public Guid Id { get; set; }
        public int BeginDate { get; set; }
        public int EndDate { get; set; }
    }
}
