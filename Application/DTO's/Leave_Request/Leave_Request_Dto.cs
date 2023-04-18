using Application.DTO_s.Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s
{
     public class Leave_Request_Dto : Base_Dto
    {

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Leave_Type_Dto Leave_Type { get; set; }
        public int Leave_TypeId { get; set; }

        public string Request_Comments { get; set; }

        public DateTime Date_Actioned { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }

    }
}
