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
    public class Get_Leave_Type_Detail_Request_Handler : IRequestHandler<Get_Leave_Type_Detail_Request, Leave_Type_Dto>
    {
        private readonly ILeave_Type_Repository _Leave_Type_Repository
;       private readonly IMapper _mapper;

        public Get_Leave_Type_Detail_Request_Handler(ILeave_Type_Repository Leave_Type, IMapper mapper)
        {
            _Leave_Type_Repository = Leave_Type;
            _mapper = mapper;
        }



        public async Task<Leave_Type_Dto> Handle(Get_Leave_Type_Detail_Request request, CancellationToken cancellationToken)
        {
            var leavetype = await _Leave_Type_Repository.Get(request.Id);

            return _mapper.Map<Leave_Type_Dto>(leavetype);
        }
    }
}
