using AutoMapper;
using HC.VehicleApp.Dtos.Bus;
using HC.VehicleApp.Dtos.Car;
using HC.VehicleApp.Entities.Concrete;
using HC.VehilceApp.BLL.Abstract;
using HC.VehilceApp.BLL.Utilities.Results;
using HC.VehilceApp.DAL.Abstract;
using HC.VehilceApp.DAL.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Concrete
{
    public class CarService : BaseService<Car, CarDto, CarCreateDto, CarUpdateDto, CarListDto>, ICarService
    {
        private readonly ICarRespository _carRepository;
        public CarService(IMapper mapper, IUow uow, ICarRespository carRepository) : base(mapper, uow)
        {
            _carRepository = carRepository;
        }

        public async Task<IResult> ChangeHeadlightsAsync(Guid id, bool HeadLightsOn)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if(car == null) { return new ErrorResult("Car not found"); }
            if(car.HeadLightOn == HeadLightsOn) { return new ErrorResult("The headlights are already in the state you entered"); }
            car.HeadLightOn = HeadLightsOn;
            await _carRepository.UpdateAsync(car);
            await _uow.SaveChangesAsync();
            return new SuccessResult("Headlights state changed successfully");
        }
    }
}
