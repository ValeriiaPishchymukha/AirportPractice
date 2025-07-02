using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.Services;
using Airport.BLL.Services.Interfaces;
using Airport.DAL.EF.Entities.HelpModels;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using Airport.DAL.EF.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplicationAirport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AirportEntityController : ControllerBase
    {
        private readonly IAirportEntityService _airportEntityService;

        public AirportEntityController(IAirportEntityService airportEntityService)
        {
            _airportEntityService = airportEntityService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<AirportEntityResponseDTO>>> GetAll([FromQuery] AirportEntityParameters parameters)
        {
            var pagedResult = await _airportEntityService.GetAllAsync(parameters);
            return Ok(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AirportEntityResponseDTO>> GetById(int id)
        {
            var airport = await _airportEntityService.GetByIDAsync(id);
            if (airport == null)
                return NotFound();
            return Ok(airport);
        }

        [HttpGet("by-country/{country}")]
        public async Task<ActionResult<List<AirportEntityResponseDTO>>> GetAirportsByCountry(string country)
        {
            var airports = await _airportEntityService.GetAirportsByCountryAsync(country);
            return Ok(airports);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AirportEntityReqDTO dto)
        {
            await _airportEntityService.CreateAsync(dto);
            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AirportEntityReqDTO dto)
        {
            await _airportEntityService.UpdateAsync(id, dto);
            return NoContent();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _airportEntityService.DeleteAsync(id);
            return NoContent();
        }
    }
}
