using Airport.BLL.DTOs.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Validation
{
    public class AirportEntityReqDTO_Validator : AbstractValidator<AirportEntityReqDTO>
    {
        public AirportEntityReqDTO_Validator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(70).WithMessage("Name cannot be longer than 70 characters.");

            RuleFor(x => x.Country)
                .NotEmpty().WithMessage("Country is required.")
                .MaximumLength(100).WithMessage("Country cannot be longer than 100 characters.");
        }
    }
}
