using Application.DTO_s;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Types.Request
{
    public class Get_Leave_Type_Detail_Request : IRequest<Leave_Type_Dto>
    {
        public int Id { get; set; }



    }
}
