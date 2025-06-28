using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities
{
    public class AircraftType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }


        public ICollection<Aircraft> Aircrafts { get; set; }
    }
}

