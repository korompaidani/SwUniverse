using AutoMapper;
using StarWars.Data.Entities;
using StarWars.Data.Models.Creatures.Society;
using StarWars.Data.Repositories;
using System;

namespace StarWars.Data.Services
{
    public class AffiliationService : IAffiliationService
    {
        private readonly IAffiliationRepository _affiliationRepository;
        private readonly IMapper _mapper;

        public AffiliationService(IAffiliationRepository affiliationRepository, IMapper mapper)
        {
            _affiliationRepository = affiliationRepository ??
                throw new ArgumentNullException(nameof(affiliationRepository));

            _mapper = mapper ??
               throw new ArgumentNullException(nameof(mapper));
        }

        public AffiliationOutputModel CreateAffiliation(AffiliationCreationModel affiliation)
        {
            var tempAffiliation = _mapper.Map<Affiliation>(affiliation);

            _affiliationRepository.CreateAffiliation(tempAffiliation);

            return _mapper.Map<AffiliationOutputModel>(tempAffiliation);
        }

        public AffiliationOutputModel GetOrCreateAffiliation(string affiliationName)
        {
            if (!_affiliationRepository.IsAffiliationExist(affiliationName))
            {
                _affiliationRepository.CreateAffiliation(new Affiliation { Name = affiliationName });
            }

            return _mapper.Map<AffiliationOutputModel>(_affiliationRepository.GetAffiliation(affiliationName));
        }

        public AffiliationOutputModel GetAffiliation(string affiliationName)
        {
            return _mapper.Map<AffiliationOutputModel>(_affiliationRepository.GetAffiliation(affiliationName));
        }

        public AffiliationOutputModel GetAffiliation(Guid affiliationId)
        {
            return _mapper.Map<AffiliationOutputModel>(_affiliationRepository.GetAffiliation(affiliationId));
        }

        public bool IsAffiliationAlreadyExist(AffiliationCreationModel affiliation)
        {
            return _affiliationRepository.IsAffiliationExist(affiliation.Name);
        }
    }
}
