using Application.DTO_s;
using Application.Features.Leave_Types.Request;

using Application.Features.Leave_Types.Request.Queries;
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
    public class Get_Leave_Type_List_Request_Handler : IRequestHandler<Get_Leave_Type_List_Request, List<Leave_Type_Dto>>
    {

        private readonly ILeave_Type_Repository  _Leave_Type_Repository; // Enherit the Interface
        private readonly IMapper _mapper;    // Use Automapper

        public Get_Leave_Type_List_Request_Handler(ILeave_Type_Repository Leave_Type_Repository , IMapper mapper) // Using of Constructor for Dependency Injection
        {

            _Leave_Type_Repository = Leave_Type_Repository;
            _mapper = mapper;

        }

       
        public async Task<List<Leave_Type_Dto>> Handle(Get_Leave_Type_List_Request request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _Leave_Type_Repository.Get_Leave_Types_With_Details();

            return _mapper.Map<List<Leave_Type_Dto>>(leaveTypes);
        }
    }
}
