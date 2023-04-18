using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Leave_Allocation : Base_Domain_Entity
    {

        public int Number_of_Days { get; set; }
        public  Leave_Type Leave_Type{ get; set; }
        public int Leave_TypeId { get; set; }
        public int Period { get; set; }




    }
}
