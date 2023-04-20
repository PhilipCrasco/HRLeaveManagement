using Application.DTO_s;
using Application.Features.Leave_Types.Request.Command;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Types.Handler.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {

        private readonly ILeaveTypeRepository _Leave_Type_Repository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leave_Type_Repository , IMapper mapper)
        {
            _Leave_Type_Repository = leave_Type_Repository;
            _mapper = mapper;
            
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);

            leaveType = await _Leave_Type_Repository.Add(leaveType);
            
            return leaveType.Id;
        }
    }
}
