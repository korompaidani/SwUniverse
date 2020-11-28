using AutoMapper;
using StarWars.Data.Entities;
using StarWars.Data.Models;
using StarWars.Data.Repositories;
using System;

namespace StarWars.Data.Services
{
    public class LifeTimeService : ILifeTimeService
    {
        private readonly ILifeTimeRepository _lifeTimeRepository;
        private readonly IMapper _mapper;

        public LifeTimeService(ILifeTimeRepository lifeTimeRepository, IMapper mapper)
        {
            _lifeTimeRepository = lifeTimeRepository ??
                throw new ArgumentNullException(nameof(lifeTimeRepository));

            _mapper = mapper ??
               throw new ArgumentNullException(nameof(mapper));
        }

        public LifeTimeOutputModel CreateLifeTime(LifeTimeCreationModel lifeTime)
        {
            var tempLifeTime = _mapper.Map<LifeTime>(lifeTime);

            _lifeTimeRepository.CreateLifeTime(tempLifeTime);

            return _mapper.Map<LifeTimeOutputModel>(tempLifeTime);
        }

        public LifeTimeOutputModel GetLifeTime(Guid lifeTimeId)
        {
            return _mapper.Map<LifeTimeOutputModel>(_lifeTimeRepository.GetLifeTime(lifeTimeId));
        }
    }
}
