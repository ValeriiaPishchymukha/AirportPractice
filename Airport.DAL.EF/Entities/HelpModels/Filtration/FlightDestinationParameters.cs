using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities.HelpModels.Filtration
{
    public class FlightDestinationParameters : Parameters
    {
        public int? AirportId { get; set; }
        public int? PassengerId { get; set; }
        public int? AircraftId { get; set; }
        public decimal? MinTicketPrice { get; set; }
        public decimal? MaxTicketPrice { get; set; }
        public DateTime? DepartureAfter { get; set; }
        public DateTime? DepartureBefore { get; set; }
    }
}
