using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Responses
{
    public class AircraftShortResponseDTO
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}
