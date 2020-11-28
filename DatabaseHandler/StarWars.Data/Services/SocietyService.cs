using AutoMapper;
using StarWars.Data.Models.Creatures.Society;
using StarWars.Data.Repositories;
using System;

namespace StarWars.Data.Services
{
    public class SocietyService : ISocietyService
    {
        private readonly ISocietyRepository _societyRepository;
        private readonly IMapper _mapper;

        public SocietyService(ISocietyRepository societyRepository, IMapper mapper)
        {
            _societyRepository = societyRepository ??
                throw new ArgumentNullException(nameof(societyRepository));

            _mapper = mapper ??
               throw new ArgumentNullException(nameof(mapper));
        }

        public SocietyOutputModel CreateSociety(SocietyCreationModel society)
        {
            throw new NotImplementedException();
        }

        public SocietyOutputModel GetOrCreateSociety(string speciesName)
        {
            throw new NotImplementedException();
        }

        public SocietyOutputModel GetSociety(string societyName)
        {
            throw new NotImplementedException();
        }

        public SocietyOutputModel GetSociety(Guid societyId)
        {
            throw new NotImplementedException();
        }

        public bool IsSocietyAlreadyExist(SocietyCreationModel society)
        {
            throw new NotImplementedException();
        }
    }
}
