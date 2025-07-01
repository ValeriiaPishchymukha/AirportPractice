using Airport.BLL.DTOs.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Validation
{
    public class PilotReqDTO_Validator : AbstractValidator<PilotReqDTO>
    {
        public PilotReqDTO_Validator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("FirstName is required.")
                .MaximumLength(30).WithMessage("FirstName cannot be longer than 30 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("LastName is required.")
                .MaximumLength(30).WithMessage("LastName cannot be longer than 30 characters.");

            RuleFor(x => x.Age)
                .InclusiveBetween(21, 62).WithMessage("Age must be between 21 and 62.");

            RuleFor(x => x.Rating)
                .InclusiveBetween(0.0, 10.0).When(x => x.Rating.HasValue)
                .WithMessage("Rating must be between 0.0 and 10.0.");

            RuleFor(x => x.AircraftIds)
                .NotNull().WithMessage("AircraftIds list cannot be null.")
                .NotEmpty().WithMessage("AircraftIds list cannot be empty.");

            RuleForEach(x => x.AircraftIds)
                .GreaterThan(0).WithMessage("Each AircraftIds must be greater than 0.");
        }
    }
}
