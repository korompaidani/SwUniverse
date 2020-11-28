using StarWars.Data.DbContexts;
using StarWars.Data.Entities;
using System;
using System.Linq;

namespace StarWars.Data.Repositories
{
    public class LifeTimeRepository : ILifeTimeRepository
    {
        private readonly SwContext _context;

        public LifeTimeRepository(SwContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateLifeTime(LifeTime lifeTime)
        {
            if (lifeTime == null)
            {
                throw new ArgumentNullException(nameof(lifeTime));
            }

            _context.Lifetimes.Add(lifeTime);

            SaveChanges();
        }

        public LifeTime GetLifeTime(Guid LifeTimeId)
        {
            if (LifeTimeId == null)
            {
                throw new ArgumentNullException(nameof(LifeTimeId));
            }

            return _context.Lifetimes.FirstOrDefault(s => s.Id == LifeTimeId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
