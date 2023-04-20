using Application.DTO_s;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Request.Request.Queries
{
    public class Get_Leave_Request_Details_Request : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
