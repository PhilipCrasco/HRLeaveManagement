using Application.DTO_s.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Allocation.Request.Queries
{
    public class GetLeaveAllocationDetail_Request : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
