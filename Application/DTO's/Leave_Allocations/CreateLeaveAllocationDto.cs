using Application.DTO_s.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Leave_Allocation
{
    public class Create_Leave_Allocation_Dto : Base_Dto
    {

        public int NumberOfDays { get; set; }
        public int Leave_TypeId { get; set; }
        public int Period { get; set; }
    }
}
