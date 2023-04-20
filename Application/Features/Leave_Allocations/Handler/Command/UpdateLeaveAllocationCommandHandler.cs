using Application.DTO_s.Leave_Requests;
using Application.Features.Leave_Allocations.Request.Command;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Allocations.Handler.Command
{
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
    {
        private readonly ILeaveAllocationRepository _Leave_Allocation_Repository;
        private readonly IMapper _mapper;

        public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leave_Allocation_Repository, IMapper mapper)
        {
            _Leave_Allocation_Repository = leave_Allocation_Repository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveallocation = await _Leave_Allocation_Repository.Get(request.LeaveAllocationDto.Id);

            _mapper.Map(request.LeaveAllocationDto, leaveallocation);

            await _Leave_Allocation_Repository.Update(leaveallocation);

            return Unit.Value;
        }
    }
}
