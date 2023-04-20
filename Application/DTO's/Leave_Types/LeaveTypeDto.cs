using Application.DTO_s.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s
{
    public class LeaveTypeDto : BaseDto // Using of Dto for AutoMapper
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }

    }
}
