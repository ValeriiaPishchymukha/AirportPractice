using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Services;
using Airport.BLL.DTOs.Services.Interfaces;
using Airport.DAL.EF.Entities.HelpModels;
using Airport.DAL.EF.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAirport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerService _passengerService;

        public PassengerController(IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<PassengerResponseDTO>>> GetAll([FromQuery] Parameters parameters)
        {
            var pagedResult = await _passengerService.GetAllAsync(parameters);
            return Ok(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PassengerResponseDTO>> GetById(int id)
        {
            var passenger = await _passengerService.GetByIdAsync(id);
            if (passenger == null)
                return NotFound();
            return Ok(passenger);
        }

        [HttpGet("by-email")]
        public async Task<ActionResult<PassengerResponseDTO>> GetByEmail([FromQuery] string email)
        {
            var passenger = await _passengerService.GetByEmailAsync(email);
            if (passenger == null)
                return NotFound();
            return Ok(passenger);
        }

        [HttpGet("search")]
        public async Task<ActionResult<List<PassengerResponseDTO>>> SearchByName([FromQuery] string name)
        {
            var passengers = await _passengerService.SearchByNameAsync(name);
            return Ok(passengers);
        }

        [HttpGet("destinations")]
        public async Task<ActionResult<List<AirportEntityResponseDTO>>> GetDestinationsByPassengerName([FromQuery] string fullName)
        {
            var destinations = await _passengerService.GetDestinationsByPassengerNameAsync(fullName);
            if (destinations == null || destinations.Count == 0)
                return NotFound();

            return Ok(destinations);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PassengerReqDTO dto)
        {
            await _passengerService.CreateAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PassengerReqDTO dto)
        {
            await _passengerService.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _passengerService.DeleteAsync(id);
            return NoContent();
        }
    }
}
