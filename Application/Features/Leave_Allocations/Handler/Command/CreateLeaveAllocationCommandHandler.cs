using Application.Features.Leave_Allocations.Request.Command;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Allocations.Handler.Command
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly ILeaveAllocationRepository _Leave_Allocation_Repository;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leave_Allocation_Repository, IMapper mapper)
        {
            _Leave_Allocation_Repository = leave_Allocation_Repository;
            _mapper = mapper;

        }



        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leave_allocation = _mapper.Map<LeaveAllocation>(request.LeaveAllocationDto);

            leave_allocation = await _Leave_Allocation_Repository.Add(leave_allocation);

            return leave_allocation.Id;
        }
    }
}
