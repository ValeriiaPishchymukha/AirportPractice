using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Requests
{
    public class AircraftReqDTO
    {
        [Required]
        [StringLength(25, ErrorMessage = "Manufacturer cannot be longer than 25 characters.")]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Model cannot be longer than 30 characters.")]
        public string Model { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Year must be a non-negative integer.")]
        public int Year { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "FlightHours must be a non-negative integer.")]
        public int? FlightHours { get; set; } 

        [Required]
        [StringLength(1, ErrorMessage = "Condition must be exactly one character.")]
        public string Condition { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "AircraftTypeId must be a non-negative integer.")]
        public int AircraftTypeId { get; set; }

        public List<int> PilotIds { get; set; }
    }
}
