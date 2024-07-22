using AutoMapper;
using HC.VehicleApp.Dtos.Boat;
using HC.VehicleApp.Dtos.Car;
using HC.VehicleApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Mapping
{
    public class BoatProfile: Profile
    {
        public BoatProfile()
        {
            CreateMap<Boat,BoatDto>().ReverseMap();
            CreateMap<BoatCreateDto,Boat>();
            CreateMap<BoatUpdateDto,Boat>();
            CreateMap<Boat,BoatListDto>();
        }
    }
}
