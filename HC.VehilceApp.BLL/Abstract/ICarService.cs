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
        /// <summary>
        /// Belirtilen id'ye sahip arabanın farlarını açıp/kapatır..
        /// </summary>
        /// <param name="id">Değişim yapılacak arabanın kimliği</param>
        /// <param name="HeadLightsOn">Arabanın farının açık/kapalı olma durumunu belirten değer.</param>
        /// <returns>İşlemin başarı durumunu ve gerekirse tüm verileri içeren bir listeyi içeren bir sonuç nesnesi döndürür.</returns>
        Task<IResult> ChangeHeadlightsAsync(Guid id, bool HeadLightsOn);
    }
}
