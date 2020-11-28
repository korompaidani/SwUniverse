using StarWars.Data.Models;
using System;

namespace StarWars.Data.Services
{
    public interface ILifeTimeService
    {
        LifeTimeOutputModel CreateLifeTime(LifeTimeCreationModel lifeTime);
        LifeTimeOutputModel GetLifeTime(Guid lifeTimeId);
    }
}
