using AutoMapper;
using HC.VehicleApp.Dtos.Boat;
using HC.VehicleApp.Dtos.Bus;
using HC.VehicleApp.Entities.Concrete;
using HC.VehilceApp.BLL.Abstract;
using HC.VehilceApp.DAL.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Concrete
{
    public class BusService : BaseService<Bus, BusDto, BusCreateDto, BusUpdateDto, BusListDto>, IBusService
    {
        public BusService(IMapper mapper, IUow uow) : base(mapper, uow)
        {
        }
    }
}
