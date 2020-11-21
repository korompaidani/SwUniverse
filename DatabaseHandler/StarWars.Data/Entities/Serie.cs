using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class Serie
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Character> Character { get; set; }
            = new List<Character>();
    }
}
