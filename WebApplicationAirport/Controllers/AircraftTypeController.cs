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
        public async Task<ActionResult<PagedList<AircraftTypeResponseDTO>>> GetAll([FromQuery] AircraftTypeParameters parameters)
        {
            var pagedResult = await _aircraftTypeService.GetAllAsync(parameters);
            return Ok(pagedResult);
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

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AircraftTypeReqDTO dto)
        {
            await _aircraftTypeService.CreateAsync(dto);
            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AircraftTypeReqDTO dto)
        {
            await _aircraftTypeService.UpdateAsync(id, dto);
            return NoContent();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aircraftTypeService.DeleteAsync(id);
            return NoContent();
        }
    }
}
