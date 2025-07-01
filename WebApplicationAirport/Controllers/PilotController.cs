using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplicationAirport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PilotController : ControllerBase
    {
        private readonly IPilotService _pilotService;

        public PilotController(IPilotService pilotService)
        {
            _pilotService = pilotService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PilotShortResponseDTO>>> GetAll()
        {
            var pilots = await _pilotService.GetAllAsync();
            return Ok(pilots);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PilotFullResponseDTO>> GetById(int id)
        {
            var pilot = await _pilotService.GetByIDAsync(id);
            if (pilot == null)
                return NotFound();
            return Ok(pilot);
        }

        [HttpGet("rating-above/{minRating}")]
        public async Task<ActionResult<List<PilotShortResponseDTO>>> GetPilotsWithRatingAbove(double minRating)
        {
            var pilots = await _pilotService.GetPilotsWithRatingAboveAsync(minRating);
            return Ok(pilots);
        }

        [HttpGet("age-range")]
        public async Task<ActionResult<List<PilotShortResponseDTO>>> GetPilotsByAgeRange([FromQuery] int minAge, [FromQuery] int maxAge)
        {
            var pilots = await _pilotService.GetPilotsByAgeRangeAsync(minAge, maxAge);
            return Ok(pilots);
        }

        [HttpGet("by-fullname")]
        public async Task<ActionResult<PilotFullResponseDTO>> GetPilotByFullName([FromQuery] string firstName, [FromQuery] string lastName)
        {
            var pilot = await _pilotService.GetPilotByFullNameAsync(firstName, lastName);
            if (pilot == null)
                return NotFound();
            return Ok(pilot);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PilotReqDTO dto)
        {
            await _pilotService.CreateAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PilotReqDTO dto)
        {
            await _pilotService.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _pilotService.DeleteAsync(id);
            return NoContent();
        }
    }
}
