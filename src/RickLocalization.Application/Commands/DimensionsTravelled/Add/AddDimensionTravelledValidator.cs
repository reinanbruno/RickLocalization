using FluentValidation;

namespace RickLocalization.Application.Commands.DimensionsTravelled.Add
{
    public class AddDimensionTravelledValidator : AbstractValidator<AddDimensionTravelledInputModel>
    {
        public AddDimensionTravelledValidator()
        {
            RuleFor(c => c.idDimension)
                   .NotNull()
                   .NotEmpty()
                   .WithMessage("Id da dimensão inválido");

            RuleFor(c => c.idRick)
                   .NotNull()
                   .NotEmpty()
                   .WithMessage("Id do rick inválido");
        }
    }
}
