using FluentValidation;
using HC.VehicleApp.Dtos.Bus;

namespace HC.VehilceApp.WebApi.Validations.Bus
{
    public class BusCreateDtoValidator:AbstractValidator<BusCreateDto>
    {
        public BusCreateDtoValidator()
        {
            RuleFor(x => x.Color)
                     .NotNull().WithMessage("Color must be selected")
                     .IsInEnum().WithMessage("Please select valid value");
        }
    }
}
