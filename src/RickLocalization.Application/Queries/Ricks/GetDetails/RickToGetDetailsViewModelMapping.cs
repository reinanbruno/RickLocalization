using AutoMapper;
using RickLocalization.Core.Entities;
using System.Linq;

namespace RickLocalization.Application.Queries.Ricks.GetDetails
{
    class RickToGetDetailsViewModelMapping : Profile
    {
        public RickToGetDetailsViewModelMapping()
        {
            CreateMap<Dimension, GetDetailsRickDimensionViewModel>()
                   .ForMember(dest =>
                         dest.id,
                         opt => opt.MapFrom(src => src.Id))
                     .ForMember(dest =>
                         dest.name,
                         opt => opt.MapFrom(src => src.Name));

            CreateMap<DimensionTravelled, GetDetailsRickDimensionViewModel>()
                   .ForMember(dest =>
                         dest.id,
                         opt => opt.MapFrom(src => src.IdDimensionCurrent))
                     .ForMember(dest =>
                         dest.name,
                         opt => opt.MapFrom(src => src.DimensionCurrent.Name));

            CreateMap<Rick, GetDetailsRickViewModel>()
                      .ForMember(dest =>
                          dest.id,
                          opt => opt.MapFrom(src => src.Id))
                      .ForMember(dest =>
                          dest.name,
                          opt => opt.MapFrom(src => src.Name))
                      .ForMember(dest =>
                          dest.urlImage,
                          opt => opt.MapFrom(src => src.UrlImage))
                      .ForMember(dest =>
                          dest.description,
                          opt => opt.MapFrom(src => src.Description))
                      .ForMember(dest =>
                          dest.dimensionOrigin,
                          opt => opt.MapFrom(src => src.DimensionOrigin))
                      .ForMember(dest =>
                          dest.dimensionCurrent,
                          opt => opt.MapFrom(src => src.DimensionsTravelled.LastOrDefault()));
        }
    }
}
