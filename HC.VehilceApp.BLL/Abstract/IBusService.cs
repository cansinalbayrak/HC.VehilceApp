using HC.VehicleApp.Dtos.Bus;
using HC.VehicleApp.Dtos.Car;
using HC.VehicleApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Abstract
{
    public interface IBusService : IService<Bus, BusDto, BusCreateDto, BusUpdateDto, BusListDto>
    {
    }
}
