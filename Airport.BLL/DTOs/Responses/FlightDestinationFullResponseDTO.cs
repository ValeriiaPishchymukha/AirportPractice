using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Responses
{
    public class FlightDestinationFullResponseDTO
    {
        public int Id { get; set; }
        public AirportEntityResponseDTO AirportEntity { get; set; }

        public DateTime Departure { get; set; }

        public AircraftShortResponseDTO Aircraft { get; set; }

        public PassengerResponseDTO Passenger { get; set; }

        public decimal TicketPrice { get; set; }
    }
}
