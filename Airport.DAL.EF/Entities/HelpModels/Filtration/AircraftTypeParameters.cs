using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities.HelpModels.Filtration
{
    public class AircraftTypeParameters : Parameters
    {
        public string? TypeName { get; set; }

        public string? OrderBy { get; set; }
    }
}
