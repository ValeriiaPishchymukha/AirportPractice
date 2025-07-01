using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities.HelpModels.Filtration
{
    public class AircraftParameters : Parameters
    {
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public int? MinYear { get; set; }
        public int? MaxYear { get; set; }
        public int? MaxFlightHours { get; set; }
    }

}
