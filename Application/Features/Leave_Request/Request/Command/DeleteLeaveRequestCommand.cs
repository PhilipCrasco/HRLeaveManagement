using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Request.Request.Command
{
    public class DeleteLeaveRequestCommand : IRequest
    {
        public int Id { get; set; }

    }
}
