using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Services.Interfaces;
using Airport.DAL.EF.Entities.HelpModels;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using Airport.DAL.EF.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAirport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AircraftController : ControllerBase
    {
        private readonly IAircraftService _aircraftService;

        public AircraftController(IAircraftService aircraftService)
        {
            _aircraftService = aircraftService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<AircraftShortResponseDTO>>> GetAll([FromQuery] AircraftParameters parameters)
        {
            var pagedResult = await _aircraftService.GetAllAsync(parameters);
            return Ok(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AircraftFullResponseDTO>> GetById(int id)
        {
            var aircraft = await _aircraftService.GetByIDAsync(id);
            if (aircraft == null)
                return NotFound();
            return Ok(aircraft);
        }

        [HttpGet("by-manufacturer/{manufacturer}")]
        public async Task<ActionResult<List<AircraftShortResponseDTO>>> GetByManufacturer(string manufacturer)
        {
            var aircrafts = await _aircraftService.GetByManufacturerAsync(manufacturer);
            return Ok(aircrafts);
        }

        [HttpGet("by-model/{model}")]
        public async Task<ActionResult<List<AircraftShortResponseDTO>>> GetByModel(string model)
        {
            var aircrafts = await _aircraftService.GetByModelAsync(model);
            return Ok(aircrafts);
        }

        [HttpGet("newer-than/{year}")]
        public async Task<ActionResult<List<AircraftShortResponseDTO>>> GetNewerThanYear(int year)
        {
            var aircrafts = await _aircraftService.GetNewerThanYearAsync(year);
            return Ok(aircrafts);
        }

        [HttpGet("with-flight-hours-less-than/{maxHours}")]
        public async Task<ActionResult<List<AircraftShortResponseDTO>>> GetWithFlightHoursLessThan(int maxHours)
        {
            var aircrafts = await _aircraftService.GetWithFlightHoursLessThanAsync(maxHours);
            return Ok(aircrafts);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AircraftReqDTO dto)
        {
            await _aircraftService.CreateAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AircraftReqDTO dto)
        {
            await _aircraftService.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aircraftService.DeleteAsync(id);
            return NoContent();
        }
    }
}
