using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Models
{
    public class SwLifeTime
    {
        public virtual SwCharacter Id { get; set; }
        public int BeginDate { get; set; }
        public int EndDate { get; set; }
    }
}
