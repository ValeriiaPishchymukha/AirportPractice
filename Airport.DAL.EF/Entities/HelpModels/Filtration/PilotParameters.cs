using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities.HelpModels.Filtration
{
    public class PilotParameters : Parameters
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public double? MinRating { get; set; }
        public double? MaxRating { get; set; }

        public string? OrderBy { get; set; }
    }
}
