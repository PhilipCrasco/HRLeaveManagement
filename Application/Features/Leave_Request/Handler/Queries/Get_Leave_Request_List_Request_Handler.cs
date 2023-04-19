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
    public class Get_Leave_Request_List_Request_Handler : IRequestHandler<Get_Leave_Request_List_Request, List<Leave_Request_Dto>>
    {

        private readonly ILeave_Request_Repository _ILeave_Request_Repository;
        private readonly IMapper _mapper;

        public Get_Leave_Request_List_Request_Handler(ILeave_Request_Repository leave_Request_Repository, IMapper mapper)
        {
            _ILeave_Request_Repository = leave_Request_Repository;
            _mapper = mapper;
            
        }


        public async Task<List<Leave_Request_Dto>> Handle(Get_Leave_Request_List_Request request, CancellationToken cancellationToken)
        {
            var LeaveRequest = await _ILeave_Request_Repository.GetAll();

            return _mapper.Map<List<Leave_Request_Dto>>(LeaveRequest);

        }
    }


}
