using Microsoft.EntityFrameworkCore;

namespace StarWars.Data.Models
{
    [Keyless]
    public class SwLifeTime
    {
        public virtual SwCharacter Id { get; set; }
        public int BeginDate { get; set; }
        public int EndDate { get; set; }
    }
}
