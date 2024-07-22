using HC.VehicleApp.Dtos.Bus;
using HC.VehicleApp.Dtos.Car;
using HC.VehicleApp.Entities.Enums;
using HC.VehilceApp.BLL.Abstract;
using HC.VehilceApp.BLL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HC.VehilceApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _carService.GetAllAsync();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _carService.GetByIdAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetByColor(Color color)
        {
            var result = await _carService.GetAsync(filter: x => x.Color == color);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Create(CarCreateDto dto)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _carService.InsertAsync(dto);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _carService.DeleteAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update(CarUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _carService.UpdateAsync(dto);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> ChangeHeadlightsAsync(Guid id, bool HeadLightsOn)
        {
            
            var result = await _carService.ChangeHeadlightsAsync(id,HeadLightsOn);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
