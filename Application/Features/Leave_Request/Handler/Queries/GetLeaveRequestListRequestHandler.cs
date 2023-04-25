using Application.DTO_s;
using Application.DTO_s.Leave_Request;
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
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestListDto>>
    {

        private readonly ILeaveRequestRepository _Leave_Request_Repository;
        private readonly IMapper _mapper;


        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leave_Request_Repository , IMapper mapper)
        {
            _Leave_Request_Repository = leave_Request_Repository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leave_request = await _Leave_Request_Repository.Get_Leave_Requests_With_Details();

            return _mapper.Map<List<LeaveRequestListDto>>(leave_request);
        }
    }
}
