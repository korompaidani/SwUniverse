using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Data.Entities
{
    public class Event
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }        
    }
}
