using Microsoft.EntityFrameworkCore;
using System;

namespace StarWars.Data.Entities
{
    [Keyless]
    public class LifeTime
    {
        public Guid Id { get; set; }
        public int BeginDate { get; set; }
        public int EndDate { get; set; }
    }
}
