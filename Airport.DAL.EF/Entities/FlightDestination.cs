using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities
{
    public class FlightDestination
    {
        public int Id { get; set; }

        public int AirportId { get; set; }
        public AirportEntity Airport { get; set; }

        public string Departure { get; set; }

        public int AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public decimal TicketPrice { get; set; }
    }
}

