using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Common
{
    public class Leave_Allocation_Dto : Base_Dto
    {

        public int Number_of_Days { get; set; }
        public Leave_Type_Dto Leave_Type { get; set; }
        public int Leave_TypeId { get; set; }
        public int Period { get; set; }


    }
}
