using System;

namespace StarWars.Data.Models
{
    public class LifeTimeOutputModel
    {
        public Guid Id { get; set; }
        public int? BeginDate { get; set; }
        public int? EndDate { get; set; }
    }
}
