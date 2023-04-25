using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Types.Request.Command
{
    public class DeleteLeaveTypeCommand : IRequest
    {

        public int Id { get; set; } 
    }
}
