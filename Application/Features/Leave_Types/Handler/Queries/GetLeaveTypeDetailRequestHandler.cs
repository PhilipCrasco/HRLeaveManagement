using Application.DTO_s;
using Application.Features.Leave_Types.Request;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Types.Handler.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _Leave_Type_Repository
;       private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository Leave_Type, IMapper mapper)
        {
            _Leave_Type_Repository = Leave_Type;
            _mapper = mapper;
        }



        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leavetype = await _Leave_Type_Repository.Get_Leave_Type_With_Details(request.Id);

            return _mapper.Map<LeaveTypeDto>(leavetype);
        }
    }
}
