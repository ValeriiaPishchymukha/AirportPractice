using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Services;
using Airport.BLL.DTOs.Services.Interfaces;
using Airport.DAL.EF.Entities.HelpModels;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using Airport.DAL.EF.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAirport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightDestinationController : ControllerBase
    {
        private readonly IFlightDestinationService _flightDestinationService;

        public FlightDestinationController(IFlightDestinationService flightDestinationService)
        {
            _flightDestinationService = flightDestinationService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<FlightDestinationShortResponseDTO>>> GetAll([FromQuery] FlightDestinationParameters parameters)
        {
            var pagedResult = await _flightDestinationService.GetAllAsync(parameters);
            return Ok(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FlightDestinationFullResponseDTO>> GetById(int id)
        {
            var flight = await _flightDestinationService.GetByIDAsync(id);
            if (flight == null)
                return NotFound();
            return Ok(flight);
        }


        [HttpGet("by-passenger/{passengerId}")]
        public async Task<ActionResult<List<FlightDestinationShortResponseDTO>>> GetFlightsByPassenger(int passengerId)
        {
            var flights = await _flightDestinationService.GetFlightsByPassengerAsync(passengerId);
            return Ok(flights);
        }

        [HttpGet("upcoming")]
        public async Task<ActionResult<List<FlightDestinationShortResponseDTO>>> GetUpcomingFlights([FromQuery] DateTime afterDate)
        {
            var flights = await _flightDestinationService.GetUpcomingFlightsAsync(afterDate);
            return Ok(flights);
        }

        [HttpGet("by-price")]
        public async Task<ActionResult<List<FlightDestinationShortResponseDTO>>> GetFlightsByPriceRange([FromQuery] decimal minPrice, [FromQuery] decimal maxPrice)
        {
            var flights = await _flightDestinationService.GetFlightsByPriceRangeAsync(minPrice, maxPrice);
            return Ok(flights);
        }

        [HttpGet("by-airport/{airportId}")]
        public async Task<ActionResult<List<FlightDestinationShortResponseDTO>>> GetFlightsByAirport(int airportId)
        {
            var flights = await _flightDestinationService.GetFlightsByAirportAsync(airportId);
            return Ok(flights);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FlightDestinationReqDTO dto)
        {
            await _flightDestinationService.CreateAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] FlightDestinationReqDTO dto)
        {
            await _flightDestinationService.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _flightDestinationService.DeleteAsync(id);
            return NoContent();
        }
    }
}
