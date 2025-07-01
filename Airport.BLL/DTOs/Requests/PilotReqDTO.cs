using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Requests
{
    public class PilotReqDTO
    {
        [Required]
        [StringLength(30, ErrorMessage = "FirstName cannot be longer than 30 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "LastName cannot be longer than 30 characters.")]
        public string LastName { get; set; }

        [Required]
        [Range(21, 62, ErrorMessage = "Age must be between 21 and 62.")]
        public int Age { get; set; }

        [Range(0.0, 10.0, ErrorMessage = "Rating must be between 0.0 and 10.0.")]
        public double? Rating { get; set; }
        public List<int> AircraftIds { get; set; }
    }
}
