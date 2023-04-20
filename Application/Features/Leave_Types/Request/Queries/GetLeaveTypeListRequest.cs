using Application.DTO_s;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Types.Request.Queries
{
    public class Get_Leave_Type_List_Request : IRequest<List<LeaveTypeDto>>
    {

    }
}
