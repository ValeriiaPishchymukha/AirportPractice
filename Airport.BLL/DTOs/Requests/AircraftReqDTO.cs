using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Requests
{
    public class AircraftReqDTO
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int FlightHours { get; set; }
        public string Condition { get; set; }
        public int AircraftTypeId { get; set; }

        public List<int> PilotIds { get; set; }
    }
}
