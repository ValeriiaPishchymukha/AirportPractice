using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Responses
{
    public class AircraftFullResponseDTO
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int FlightHours { get; set; }
        public string Condition { get; set; }

        public AircraftTypeResponseDTO AircraftType { get; set; }

        public List<PilotShortResponseDTO> Pilots { get; set; }
    }
}
