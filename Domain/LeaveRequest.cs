using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Leave_Request : Base_Domain_Entity
    {
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Leave_Type Leave_Type { get; set; }
        public int Leave_TypeId{ get; set; }

        public DateTime Date_Requested { get; set; }

        public string Request_Comments { get; set; }

        public DateTime ? Date_Actioned { get; set; }  

        public bool ? Approved { get; set; }

        public bool Cancelled { get; set; }


    }
}
