using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Requests
{
    public class AirportEntityReqDTO
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
