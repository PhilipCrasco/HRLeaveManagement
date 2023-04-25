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
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand>
    {

        private readonly ILeaveAllocationRepository _Leave_Allocation_Repository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leave_Allocation_Repository, IMapper mapper)
        {
            _Leave_Allocation_Repository = leave_Allocation_Repository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _Leave_Allocation_Repository.Get(request.Id);

            await _Leave_Allocation_Repository.Delete(leaveAllocation);

            return Unit.Value;
        }
    }
}
