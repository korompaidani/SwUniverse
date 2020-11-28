using StarWars.Data.DbContexts;
using StarWars.Data.Entities;
using System;
using System.Linq;

namespace StarWars.Data.Repositories
{
    public class SocietyRepository : ISocietyRepository
    {
        private readonly SwContext _context;

        public SocietyRepository(SwContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateSociety(Society society)
        {
            if (society == null)
            {
                throw new ArgumentNullException(nameof(society));
            }

            _context.Society.Add(society);

            SaveChanges();
        }

        public Society GetSociety(Guid societyId)
        {
            if (societyId == null)
            {
                throw new ArgumentNullException(nameof(societyId));
            }

            return _context.Society.FirstOrDefault(s => s.Id == societyId);
        }

        public Society GetSociety(string societyName)
        {
            if (societyName == null)
            {
                throw new ArgumentNullException(nameof(societyName));
            }

            return _context.Society.FirstOrDefault(s => s.Name == societyName);
        }

        public bool IsSocietyExist(string societyName)
        {
            if (societyName == null)
            {
                throw new ArgumentNullException(nameof(societyName));
            }

            return _context.Society.Any(s => s.Name == societyName);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
