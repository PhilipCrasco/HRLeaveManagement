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
    public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetail_Request, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _Leave_Allocation_Repository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leave_Allocation_Repository, IMapper mapper)
        {
            _Leave_Allocation_Repository = leave_Allocation_Repository;
            _mapper = mapper;

        }

     
        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetail_Request request, CancellationToken cancellationToken)
        {
            var leaveallocation = await _Leave_Allocation_Repository.Get_Leave_Allocation_With_Details(request.Id);

            return _mapper.Map<LeaveAllocationDto>(leaveallocation);    
        }
    }
}
