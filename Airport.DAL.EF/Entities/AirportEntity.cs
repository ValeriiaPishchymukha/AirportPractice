using Airport.DAL.EF.Entities.HelpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities
{
    public class AirportEntity : BaseModel
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public ICollection<FlightDestination> FlightDestinations { get; set; }
    }
}
