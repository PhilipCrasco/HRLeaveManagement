using Application.DTO_s.Leave_Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Leave_Requests.Validators
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {

        public CreateLeaveRequestDtoValidator()
        {
            RuleFor(p => p.StartDate)
                .LessThan(p => p.EndDate).WithMessage("{Property name} must be before {ComparisonValue}"); // using of less than and greater than for validation

            RuleFor(p => p.EndDate)
                .GreaterThan(p => p.StartDate).WithMessage("{Property name} must be after {ComparisonValue}");

            //RuleFor(p =>p.LeaveTypeId)
            //       .MustAsync(async (id, token) =>
            //       {

            //       }).WithMessage("{Property name } does not exist")
                
        }
    }
}
