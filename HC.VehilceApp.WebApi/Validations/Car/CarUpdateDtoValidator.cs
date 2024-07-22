using FluentValidation;
using HC.VehicleApp.Dtos.Car;

namespace HC.VehilceApp.WebApi.Validations.Car
{
    public class CarUpdateDtoValidator:AbstractValidator<CarUpdateDto>
    {
        public CarUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id).NotEmpty().WithMessage("Id required");
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
