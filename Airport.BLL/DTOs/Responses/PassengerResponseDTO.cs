using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Responses
{
    public class PassengerResponseDTO
    {
        public int Id {  get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
