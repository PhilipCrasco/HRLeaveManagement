using Application.Persistance.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Leave_Requests.Validators
{
    public class ILeaveTypeDtoValidator : AbstractValidator<LeaveRequestDto>
    {

        private readonly ILeaveTypeRepository _LeaveTypeRepository;

        public ILeaveTypeDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _LeaveTypeRepository = leaveTypeRepository;


            RuleFor(p => p.StartDate)
              .LessThan(p => p.EndDate).WithMessage("{Property name} must be before {ComparisonValue}"); // using of less than and greater than for validation

            RuleFor(p => p.EndDate)
                .GreaterThan(p => p.StartDate).WithMessage("{Property name} must be after {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId)
                   .GreaterThan(0)
                   .MustAsync(async (id, token) =>
                   {
                       var leaveTypeExists = await _LeaveTypeRepository.Exists(id);
                       return !leaveTypeExists;

                   }).WithMessage("{Property name } does not exist");




        }




    }
}
