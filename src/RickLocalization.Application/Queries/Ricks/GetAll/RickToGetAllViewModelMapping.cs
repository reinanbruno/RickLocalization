using AutoMapper;
using RickLocalization.Core.Entities;

namespace RickLocalization.Application.Queries.Ricks.GetAll
{
    public class RickToGetAllViewModelMapping : Profile
    {
        public RickToGetAllViewModelMapping()
        {
            CreateMap<Rick, GetAllRickViewModel>()
                      .ForMember(dest =>
                          dest.name,
                          opt => opt.MapFrom(src => src.Name))
                      .ForMember(dest =>
                          dest.nameMorty,
                          opt => opt.MapFrom(src => src.Morty.Name))
                      .ForMember(dest =>
                          dest.urlImage,
                          opt => opt.MapFrom(src => src.UrlImage))
                      .ForMember(dest =>
                          dest.urlImageMorty,
                          opt => opt.MapFrom(src => src.Morty.UrlImage))
                      .ForMember(dest =>
                          dest.url,
                          opt => opt.MapFrom(src => src.Url));

        }
    }
}
