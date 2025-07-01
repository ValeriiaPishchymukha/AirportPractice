using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Requests
{
    public class AircraftTypeReqDTO
    {
        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string TypeName { get; set; }
    }
}
