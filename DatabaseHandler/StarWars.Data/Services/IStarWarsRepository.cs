using StarWars.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Services
{
    interface IStarWarsRepository
    {
        void AddCharacter(Character character);
    }
}
