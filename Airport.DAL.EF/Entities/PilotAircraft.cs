using Airport.DAL.EF.Entities.HelpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities
{
    public class PilotAircraft
    {
        public int PilotId { get; set; }
        public Pilot Pilot { get; set; }

        public int AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }
    }
}

