using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Leave_Types.Validators
{
    public class CreateLeaveTypeDtoValidators : AbstractValidator<CreateLeaveTypeDto>
    {

        public CreateLeaveTypeDtoValidators() // Use of Fluent Validation 
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{Property name} is required") // Name will show as Property Name in result
                .NotNull()
                .MaximumLength(50).WithMessage("{Property name} must not exceed 50 characters");

            RuleFor(p => p.DefaultDays)
              .NotEmpty().WithMessage("{Property name} is required") // Name will show as Property Name in result
              .GreaterThan(0).WithMessage("{Property name} must be at least 1")
              .LessThan(100).WithMessage("{Property name }must be less than 100");
    

        }

    }
}
