using Application.DTO_s.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Leave_Requests
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {

        public bool ? Approved { get; set; }
    }
}
