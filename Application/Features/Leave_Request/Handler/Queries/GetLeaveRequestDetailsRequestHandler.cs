using Application.DTO_s;
using Application.Features.Leave_Request.Request.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Request.Handler.Queries
{
    public class Get_Leave_Request_Details_Request_Handler : IRequestHandler<Get_Leave_Request_Details_Request, Leave_Request_Dto>
    {

        private readonly ILeaveRequestRepository _Leave_Request_Repository;
        private readonly IMapper _mapper;

        public Get_Leave_Request_Details_Request_Handler( ILeaveRequestRepository leave_Request , IMapper mapper)
        {
            _Leave_Request_Repository = leave_Request;
            _mapper = mapper;
        }

        public async Task<Leave_Request_Dto> Handle(Get_Leave_Request_Details_Request request, CancellationToken cancellationToken)
        {
            var leave_request = await _Leave_Request_Repository.Get_Leave_Request_With_Details(request.Id);

            return _mapper.Map<Leave_Request_Dto>(leave_request);
        }
    }
}
