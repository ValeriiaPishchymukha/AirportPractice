using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int FlightHours { get; set; }
        public string Condition { get; set; }

        public int AircraftTypeId { get; set; }

        public AircraftType AircraftType { get; set; }


        public ICollection<PilotAircraft> PilotAircrafts { get; set; }
        public ICollection<FlightDestination> FlightDestinations { get; set; }

    }
}

