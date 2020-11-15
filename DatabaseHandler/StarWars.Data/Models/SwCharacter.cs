using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Models
{
    public class SwCharacter
    {        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
    }
}
