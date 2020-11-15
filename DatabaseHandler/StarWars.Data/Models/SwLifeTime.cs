using Microsoft.EntityFrameworkCore;
using System;

namespace StarWars.Data.Models
{
    [Keyless]
    public class SwLifeTime
    {
        public Guid Id { get; set; }
        public int BeginDate { get; set; }
        public int EndDate { get; set; }
    }
}
