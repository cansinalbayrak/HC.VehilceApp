using AutoMapper;
using HC.VehicleApp.Dtos.Car;
using HC.VehicleApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Mapping
{
    public class CarProfile:Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<CarCreateDto, Car>();
            CreateMap<CarUpdateDto, Car>();
            CreateMap<Car, CarListDto>();
        }
    }
}
