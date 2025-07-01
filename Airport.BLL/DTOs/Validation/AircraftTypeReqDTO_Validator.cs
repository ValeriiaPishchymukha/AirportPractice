using Airport.BLL.DTOs.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Validation
{
    public class AircraftTypeReqDTO_Validator : AbstractValidator<AircraftTypeReqDTO>
    {
        public AircraftTypeReqDTO_Validator()
        {
            RuleFor(x => x.TypeName)
                .NotEmpty().WithMessage("TypeName is required.")
                .MaximumLength(30).WithMessage("TypeName cannot be longer than 30 characters.");
        }
    }
}
