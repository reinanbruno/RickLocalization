using AutoMapper;
using RickLocalization.Core.Entities;

namespace RickLocalization.Application.Queries.DimensionsTravelled.GetTravels
{
    public class DimensionTravelledToGetTravelsViewModelMapping : Profile
    {
        public DimensionTravelledToGetTravelsViewModelMapping()
        {            
            CreateMap<DimensionTravelled, GetTravelsViewModel>()
                     .ForMember(dest =>
                         dest.nameDimensionBefore,
                         opt => opt.MapFrom(src => src.DimensionBefore.Name))
                     .ForMember(dest =>
                         dest.nameDimensionCurrent,
                         opt => opt.MapFrom(src => src.DimensionCurrent.Name));
        }

    }
}
