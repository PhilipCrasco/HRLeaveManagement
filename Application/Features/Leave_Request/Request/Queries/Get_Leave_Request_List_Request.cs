﻿using Application.DTO_s;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Request.Request.Queries
{
    public class Get_Leave_Request_List_Request : IRequest<List<Leave_Request_Dto>>
    {
    }
}