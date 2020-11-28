using StarWars.Data.Entities;
using System;

namespace StarWars.Data.Repositories
{
    public interface ILifeTimeRepository : IRepository
    {
        void CreateLifeTime(LifeTime lifeTime);
        LifeTime GetLifeTime(Guid LifeTimeId);
    }
}
