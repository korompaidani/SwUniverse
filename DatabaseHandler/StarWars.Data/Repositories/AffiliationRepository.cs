using StarWars.Data.DbContexts;
using StarWars.Data.Entities;
using System;
using System.Linq;

namespace StarWars.Data.Repositories
{
    public class AffiliationRepository : IAffiliationRepository
    {
        private readonly SwContext _context;

        public AffiliationRepository(SwContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateAffiliation(Affiliation affiliation)
        {
            if (affiliation == null)
            {
                throw new ArgumentNullException(nameof(affiliation));
            }

            _context.Affiliations.Add(affiliation);

            SaveChanges();
        }

        public Affiliation GetAffiliation(Guid affiliationId)
        {
            if (affiliationId == null)
            {
                throw new ArgumentNullException(nameof(affiliationId));
            }

            return _context.Affiliations.FirstOrDefault(s => s.Id == affiliationId);
        }

        public Affiliation GetAffiliation(string affiliationName)
        {
            if (affiliationName == null)
            {
                throw new ArgumentNullException(nameof(affiliationName));
            }

            return _context.Affiliations.FirstOrDefault(s => s.Name == affiliationName);
        }

        public bool IsAffiliationExist(string affiliationName)
        {
            if (affiliationName == null)
            {
                throw new ArgumentNullException(nameof(affiliationName));
            }

            return _context.Affiliations.Any(s => s.Name == affiliationName);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
