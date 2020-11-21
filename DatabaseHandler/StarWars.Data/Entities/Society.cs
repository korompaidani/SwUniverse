using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarWars.Data.Entities
{
    public class Society
    {
        [Key]
        public Guid Id { get; set; }
    }
}
