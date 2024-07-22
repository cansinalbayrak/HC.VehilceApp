using FluentValidation;
using HC.VehicleApp.Dtos.Car;

namespace HC.VehilceApp.WebApi.Validations.Car
{
    public class CarCreateDtoValidator:AbstractValidator<CarCreateDto>
    {
        public CarCreateDtoValidator()
        {
            RuleFor(x => x.Color)
                     .NotNull().WithMessage("Color must be selected")
                     .IsInEnum().WithMessage("Please select valid value");
            RuleFor(x => x.HeadLightOn)
                     .NotNull().WithMessage("HeadLight must be selected")
                     .Must(x => x == true || x == false).WithMessage("Please select valid value");
            RuleFor(x => x.Wheel)
                     .NotNull().WithMessage("Wheel type must be selected")
                     .IsInEnum().WithMessage("Please select valid value");
        }
    }
}
