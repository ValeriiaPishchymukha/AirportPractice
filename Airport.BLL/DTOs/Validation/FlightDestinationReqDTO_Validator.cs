using Airport.BLL.DTOs.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Validation
{
    public class FlightDestinationReqDTO_Validator : AbstractValidator<FlightDestinationReqDTO>
    {
        public FlightDestinationReqDTO_Validator()
        {
            RuleFor(x => x.AirportId)
                .GreaterThanOrEqualTo(0)
                .WithMessage("AirportId must be a non-negative integer.");

            RuleFor(x => x.Departure)
                .NotEmpty()
                .WithMessage("Departure date is required.");

            RuleFor(x => x.AircraftId)
                .GreaterThanOrEqualTo(0)
                .WithMessage("AircraftId must be a non-negative integer.");

            RuleFor(x => x.PassengerId)
                .GreaterThanOrEqualTo(0)
                .WithMessage("PassengerId must be a non-negative integer.");

            RuleFor(x => x.TicketPrice)
                .GreaterThan(0)
                .WithMessage("TicketPrice must be positive.");
        }
    }
}
