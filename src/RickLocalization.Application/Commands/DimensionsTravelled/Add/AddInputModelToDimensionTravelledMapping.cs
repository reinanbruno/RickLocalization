using AutoMapper;
using RickLocalization.Core.Entities;
using System;

namespace RickLocalization.Application.Commands.DimensionsTravelled.Add
{
    public class AddInputModelToDimensionTravelledMapping : Profile
    {
        public AddInputModelToDimensionTravelledMapping()
        {
            CreateMap<AddDimensionTravelledInputModel, DimensionTravelled>()
                      .ForMember(dest =>
                          dest.Id,
                          opt => opt.MapFrom(src => Guid.NewGuid()))
                      .ForMember(dest =>
                          dest.IdDimensionCurrent,
                          opt => opt.MapFrom(src => src.idDimension))
                      .ForMember(dest =>
                          dest.IdRick,
                          opt => opt.MapFrom(src => src.idRick))
                      .ForMember(dest =>
                          dest.RegistrationDate,
                          opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}
