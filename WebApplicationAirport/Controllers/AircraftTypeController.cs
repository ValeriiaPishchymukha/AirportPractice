using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAirport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AircraftTypeController : ControllerBase
    {
        private readonly IAircraftTypeService _aircraftTypeService;

        public AircraftTypeController(IAircraftTypeService aircraftTypeService)
        {
            _aircraftTypeService = aircraftTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AircraftTypeResponseDTO>>> GetAll()
        {
            var types = await _aircraftTypeService.GetAllAsync();
            return Ok(types);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AircraftTypeResponseDTO>> GetById(int id)
        {
            var type = await _aircraftTypeService.GetByIDAsync(id);
            if (type == null)
                return NotFound();
            return Ok(type);
        }

        [HttpGet("with-aircrafts")]
        public async Task<ActionResult<List<AircraftTypeResponseDTO>>> GetTypesWithAircrafts()
        {
            var types = await _aircraftTypeService.GetTypesWithAircraftsAsync();
            return Ok(types);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AircraftTypeReqDTO dto)
        {
            await _aircraftTypeService.CreateAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AircraftTypeReqDTO dto)
        {
            await _aircraftTypeService.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aircraftTypeService.DeleteAsync(id);
            return NoContent();
        }
    }
}
