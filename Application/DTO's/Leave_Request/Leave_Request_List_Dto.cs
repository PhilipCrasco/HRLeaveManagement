using Application.DTO_s.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Leave_Request
{
    internal class Leave_Request_List_Dto : Base_Dto
    {
        public Leave_Type_Dto leave_Type { get; set; }
        public DateTime Date_Requested { get; set; }
        public bool ? Approved { get; set; }



    }
}
