using Airport.BLL.DTOs.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Validation
{
    public class PassengerReqDTO_Validator : AbstractValidator<PassengerReqDTO>
    {
        public PassengerReqDTO_Validator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("FullName is required.")
                .MaximumLength(100).WithMessage("FullName cannot be longer than 100 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .MaximumLength(50).WithMessage("Email cannot be longer than 50 characters.")
                .EmailAddress().WithMessage("Invalid email format.");
        }
    }
}
