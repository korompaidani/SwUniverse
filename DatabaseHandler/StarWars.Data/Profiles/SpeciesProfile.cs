﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Data.Profiles
{
    public class SpeciesProfile : Profile
    {
        public SpeciesProfile()
        {
            CreateMap<Models.Creatures.Species.SpeciesCreationDto, Entities.Species>();
            CreateMap<Entities.Species, Models.Creatures.Species.SpeciesDto>();
        }
    }
}