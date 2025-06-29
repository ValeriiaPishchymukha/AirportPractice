using Airport.DAL.EF.Entities.HelpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities
{
    public class Passenger : BaseModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }

       public ICollection<FlightDestination> FlightDestinations { get; set; }
    }
}
