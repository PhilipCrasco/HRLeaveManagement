using Application.DTO_s.Common;
using Application.Features.Leave_Allocation.Request.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Allocation.Handler.Queries
{
    public class GetLeaveAllocationRequestHandler : IRequestHandler<GetLeaveAllocationRequest, List<LeaveAllocationDto>>
    {

        private readonly ILeaveAllocationRepository _Leave_Allocation_Repository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationRequestHandler(ILeaveAllocationRepository leave_Allocation_Repository , IMapper mapper )
        {
            _Leave_Allocation_Repository = leave_Allocation_Repository;
            _mapper = mapper;

        }


        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _Leave_Allocation_Repository.Get_Leave_Allocations_With_Details();

            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocation);
        }
    }
}
