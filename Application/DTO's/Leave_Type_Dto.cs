using Application.DTO_s.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s
{
    public class Leave_Type_Dto : Base_Dto // Using of Dto for AutoMapper
    {
        public string Name { get; set; }
        public int Default_Days { get; set; }

    }
}
