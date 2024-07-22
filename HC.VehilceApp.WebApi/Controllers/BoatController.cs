using HC.VehicleApp.Dtos.Boat;
using HC.VehicleApp.Entities.Enums;
using HC.VehilceApp.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using Color = HC.VehicleApp.Entities.Enums.Color;

namespace HC.VehilceApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _boatService.GetAllAsync();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _boatService.GetByIdAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetByColor(Color color)
        {
            var result = await _boatService.GetAsync(filter:x=>x.Color == color);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Create(BoatCreateDto dto)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _boatService.InsertAsync(dto);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _boatService.DeleteAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update(BoatUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _boatService.UpdateAsync(dto);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

    }
}
