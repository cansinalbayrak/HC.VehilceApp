using FluentValidation;
using HC.VehicleApp.Dtos.Boat;

namespace HC.VehilceApp.WebApi.Validations.Boat
{
    public class BoatCreateDtoValidator:AbstractValidator<BoatCreateDto>
    {
        public BoatCreateDtoValidator()
        {
            RuleFor(x => x.Color)
                     .NotNull().WithMessage("Color must be selected")
                     .IsInEnum().WithMessage("Please select valid value");
                     
        }
    }
}
