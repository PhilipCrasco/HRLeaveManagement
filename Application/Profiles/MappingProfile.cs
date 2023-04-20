using Application.DTO_s;
using Application.DTO_s.Common;
using Application.DTO_s.Leave_Allocation;
using Application.DTO_s.Leave_Request;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class Mapping_Profile : Profile  // AutoMapper SetUp
    {

        public Mapping_Profile()
        {
            CreateMap<LeaveRequest, Leave_Request_Dto>().ReverseMap();
            CreateMap<LeaveRequest, Leave_Request_List_Dto>().ReverseMap();
            CreateMap<LeaveRequest, Create_Leave_Request_Dto>().ReverseMap();
            CreateMap<LeaveType, Leave_Type_Dto>().ReverseMap();
            CreateMap<LeaveAllocation , Leave_Allocation_Dto>().ReverseMap();
            CreateMap<LeaveAllocation, Create_Leave_Allocation_Dto>().ReverseMap();
        }


    }
}
