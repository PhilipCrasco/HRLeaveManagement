using Application.DTO_s.Leave_Allocations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Allocations.Request.Command
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {

        public UpdateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
