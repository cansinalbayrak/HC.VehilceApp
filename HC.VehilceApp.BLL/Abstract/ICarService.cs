using HC.VehicleApp.Dtos.Car;
using HC.VehicleApp.Entities.Concrete;
using HC.VehilceApp.BLL.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Abstract
{
    public interface ICarService : IService<Car, CarDto, CarCreateDto, CarUpdateDto, CarListDto> 
    {
        Task<IResult> ChangeHeadlightsAsync(Guid id, bool HeadLightsOn);
    }
}
