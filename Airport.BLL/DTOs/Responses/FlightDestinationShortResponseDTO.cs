using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Responses
{
    public class FlightDestinationShortResponseDTO
    {
        public int Id { get; set; }
        public int AirportId { get; set; }

        public DateTime Departure { get; set; }

        public int AircraftId { get; set; }

        public int PassengerId { get; set; }

        public decimal TicketPrice { get; set; }
    }
}
