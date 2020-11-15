using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Entities
{
    public class Character
    {        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
    }
}
