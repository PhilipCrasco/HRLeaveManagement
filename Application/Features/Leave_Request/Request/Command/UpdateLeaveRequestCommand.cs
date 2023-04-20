using Application.DTO_s.Leave_Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Request.Request.Command
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public UpdateLeaveRequestDto LeaveRequestDto { get; set; }

    }
}
