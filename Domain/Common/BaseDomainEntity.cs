using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public  abstract class Base_Domain_Entity
    {
        public int Id { get; set; }
        public DateTime Date_Created { get; set; }
        public string Created_By { get; set; }
        public DateTime Last_Modification { get; set; }
        public string Last_Modified { get; set; }   


    }
}
