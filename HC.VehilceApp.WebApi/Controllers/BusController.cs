using HC.VehicleApp.Dtos.Boat;
using HC.VehicleApp.Dtos.Bus;
using HC.VehicleApp.Entities.Enums;
using HC.VehilceApp.BLL.Abstract;
using HC.VehilceApp.BLL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HC.VehilceApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _busService.GetAllAsync();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _busService.GetByIdAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetByColor(Color color)
        {
            var result = await _busService.GetAllAsync(filter: x => x.Color == color);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Create(BusCreateDto dto)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _busService.InsertAsync(dto);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _busService.DeleteAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update(BusUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _busService.UpdateAsync(dto);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
