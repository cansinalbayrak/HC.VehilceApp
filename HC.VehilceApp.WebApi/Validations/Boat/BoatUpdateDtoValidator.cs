using FluentValidation;
using HC.VehicleApp.Dtos.Boat;

namespace HC.VehilceApp.WebApi.Validations.Boat
{
    public class BoatUpdateDtoValidator:AbstractValidator<BoatUpdateDto>
    {
        public BoatUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id).NotEmpty().WithMessage("Id required");
            RuleFor(x => x.Color)
                     .NotNull().WithMessage("Color must be selected")
                     .IsInEnum().WithMessage("Please select valid value");
        }
    }
}
