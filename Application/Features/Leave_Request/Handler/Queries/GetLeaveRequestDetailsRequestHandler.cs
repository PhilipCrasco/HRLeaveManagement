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
    public class GetLeaveRequestDetailsRequestHandler : IRequestHandler<GetLeaveRequestDetailsRequest, LeaveRequestDto>
    {

        private readonly ILeaveRequestRepository _Leave_Request_Repository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailsRequestHandler( ILeaveRequestRepository leave_Request , IMapper mapper)
        {
            _Leave_Request_Repository = leave_Request;
            _mapper = mapper;
        }

        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailsRequest request, CancellationToken cancellationToken)
        {
            var leave_request = await _Leave_Request_Repository.Get_Leave_Request_With_Details(request.Id);

            return _mapper.Map<LeaveRequestDto>(leave_request);
        }
    }
}
