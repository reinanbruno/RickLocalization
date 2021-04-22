using AutoMapper;
using RickLocalization.Core.Entities;

namespace RickLocalization.Application.Queries.Dimensions.GetAll
{
    public class DimensionToGetAllViewModelMapping : Profile
    {
        public DimensionToGetAllViewModelMapping()
        {
            CreateMap<Dimension, GetAllDimensionViewModel>()
                      .ForMember(dest =>
                          dest.id,
                          opt => opt.MapFrom(src => src.Id))
                      .ForMember(dest =>
                          dest.name,
                          opt => opt.MapFrom(src => src.Name));
        }
    }
}
