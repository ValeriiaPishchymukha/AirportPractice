using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities.HelpModels.Filtration
{
    public class AirportEntityParameters : Parameters
    {
        public string? Name { get; set; }
        public string? Country { get; set; }

        public string? OrderBy { get; set; }
    }
}
