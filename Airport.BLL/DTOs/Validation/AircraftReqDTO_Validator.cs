using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.BLL.DTOs.Requests;
using FluentValidation;

namespace Airport.BLL.DTOs.Validation
{
    public class AircraftReqDTO_Validator : AbstractValidator<AircraftReqDTO>
    {
        public AircraftReqDTO_Validator()
        {
            RuleFor(x => x.Manufacturer)
                .NotEmpty().WithMessage("Manufacturer is required.")
                .MaximumLength(25).WithMessage("Manufacturer cannot be longer than 25 characters.");

            RuleFor(x => x.Model)
                .NotEmpty().WithMessage("Model is required.")
                .MaximumLength(30).WithMessage("Model cannot be longer than 30 characters.");

            RuleFor(x => x.Year)
                .InclusiveBetween(0, int.MaxValue)
                .WithMessage("Year must be a non-negative integer.");

            RuleFor(x => x.FlightHours)
                .GreaterThanOrEqualTo(0)
                .When(x => x.FlightHours.HasValue)
                .WithMessage("FlightHours must be a non-negative integer.");

            RuleFor(x => x.Condition)
                .NotEmpty().WithMessage("Condition is required.")
                .Length(1).WithMessage("Condition must be exactly one character.");

            RuleFor(x => x.AircraftTypeId)
                .GreaterThanOrEqualTo(0)
                .WithMessage("AircraftTypeId must be a non-negative integer.");

            RuleFor(x => x.PilotIds)
                .NotNull().WithMessage("PilotIds list cannot be null.")
                .NotEmpty().WithMessage("PilotIds list cannot be empty.");

            RuleForEach(x => x.PilotIds)
                .GreaterThan(0).WithMessage("Each PilotId must be greater than 0.");
        }
    }

}
