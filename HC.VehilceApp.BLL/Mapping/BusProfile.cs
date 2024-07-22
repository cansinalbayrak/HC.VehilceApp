using AutoMapper;
using HC.VehicleApp.Dtos.Bus;
using HC.VehicleApp.Dtos.Car;
using HC.VehicleApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Mapping
{
    public class BusProfile:Profile
    {
        public BusProfile()
        {
            CreateMap<Bus, BusDto>().ReverseMap();
            CreateMap<BusCreateDto, Bus>();
            CreateMap<BusUpdateDto, Bus>();
            CreateMap<Bus, BusListDto>();
        }
    }
}
