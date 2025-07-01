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
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "AirportId must be a non-negative integer.")]
        public int AirportId { get; set; }

        [Required]
        public DateTime Departure { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "AircraftId must be a non-negative integer.")]
        public int AircraftId { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "PassengerId must be a non-negative integer.")]
        public int PassengerId { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "79228162514264337593543950335", ErrorMessage = "TicketPrice must be positive.")]
        public decimal TicketPrice { get; set; } = 15;
    }
}
