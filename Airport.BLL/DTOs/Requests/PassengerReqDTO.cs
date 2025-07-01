using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Requests
{
    public class PassengerReqDTO
    {
        [Required]
        [StringLength(100, ErrorMessage = "FullName cannot be longer than 100 characters.")]
        public string FullName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Email cannot be longer than 50 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }
}
