﻿using AutoMapper;

namespace StarWars.Data.Profiles
{
    public class SpeciesProfile : Profile
    {
        public SpeciesProfile()
        {
            CreateMap<Models.Creatures.Species.SpeciesCreationModel, Entities.Species>();
            CreateMap<Entities.Species, Models.Creatures.Species.SpeciesOutputModel>();
            CreateMap<Models.Creatures.Species.SpeciesOutputModel, Entities.Species>();
            CreateMap<Models.Creatures.Species.SpeciesCreationModel, Models.Creatures.Species.SpeciesOutputModel>();
        }
    }
}
