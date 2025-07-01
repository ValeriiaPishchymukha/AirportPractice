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
        [Required]
        [StringLength(70, ErrorMessage = "Name cannot be longer than 70 characters.")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Country cannot be longer than 100 characters.")]
        public string Country { get; set; }
    }
}
