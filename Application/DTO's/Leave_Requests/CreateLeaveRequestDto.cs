using Application.DTO_s.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Leave_Request
{
    public class CreateLeaveRequestDto : BaseDto
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set;}
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }

    }
}
