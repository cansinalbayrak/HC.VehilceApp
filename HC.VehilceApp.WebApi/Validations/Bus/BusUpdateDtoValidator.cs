using FluentValidation;
using HC.VehicleApp.Dtos.Bus;

namespace HC.VehilceApp.WebApi.Validations.Bus
{
    public class BusUpdateDtoValidator:AbstractValidator<BusUpdateDto>
    {
        public BusUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id).NotEmpty().WithMessage("Id required");
            RuleFor(x => x.Color)
                     .NotNull().WithMessage("Color must be selected")
                     .IsInEnum().WithMessage("Please select valid value");
        }
    }
}
