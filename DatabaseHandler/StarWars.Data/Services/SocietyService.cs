using AutoMapper;
using StarWars.Data.Entities;
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
            var tempSociety = _mapper.Map<Society>(society);

            _societyRepository.CreateSociety(tempSociety);

            return _mapper.Map<SocietyOutputModel>(tempSociety);
        }

        public SocietyOutputModel GetOrCreateSociety(string societyName)
        {
            if (!_societyRepository.IsSocietyExist(societyName))
            {
                _societyRepository.CreateSociety(new Society { Name = societyName });
            }

            return _mapper.Map<SocietyOutputModel>(_societyRepository.GetSociety(societyName));
        }

        public SocietyOutputModel GetSociety(string societyName)
        {
            return _mapper.Map<SocietyOutputModel>(_societyRepository.GetSociety(societyName));
        }

        public SocietyOutputModel GetSociety(Guid societyId)
        {
            return _mapper.Map<SocietyOutputModel>(_societyRepository.GetSociety(societyId));
        }

        public bool IsSocietyAlreadyExist(SocietyCreationModel society)
        {
            return _societyRepository.IsSocietyExist(society.Name);
        }
    }
}
