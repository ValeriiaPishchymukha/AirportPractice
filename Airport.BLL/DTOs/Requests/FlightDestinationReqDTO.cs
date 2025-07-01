using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Requests
{
    public class FlightDestinationReqDTO
    {
        public int AirportId { get; set; }
        public DateTime Departure { get; set; }
        public int AircraftId { get; set; }
        public int PassengerId { get; set; }
        public decimal TicketPrice { get; set; } = 15;
    }
}
