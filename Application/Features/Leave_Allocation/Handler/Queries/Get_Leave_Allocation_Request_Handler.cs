﻿using Application.DTO_s.Common;
using Application.Features.Leave_Allocation.Request.Queries;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Allocation.Handler.Queries
{
    public class Get_Leave_Allocation_Request_Handler : IRequestHandler<Get_Leave_Allocation_Request, List<Leave_Allocation_Dto>>
    {

        private readonly ILeave_Allocation_Repository _Leave_Allocation_Repository;
        private readonly IMapper _mapper;

        public Get_Leave_Allocation_Request_Handler(ILeave_Allocation_Repository leave_Allocation_Repository , IMapper mapper )
        {
            _Leave_Allocation_Repository = leave_Allocation_Repository;
            _mapper = mapper;

        }


        public async Task<List<Leave_Allocation_Dto>> Handle(Get_Leave_Allocation_Request request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _Leave_Allocation_Repository.GetAll();

            return _mapper.Map<List<Leave_Allocation_Dto>>(leaveAllocation);
        }
    }
}
