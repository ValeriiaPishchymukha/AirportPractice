using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities.HelpModels.Filtration
{
    public class PassengerParameters : Parameters
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
    }
}
