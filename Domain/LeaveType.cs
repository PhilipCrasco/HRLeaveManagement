using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Leave_Type : Base_Domain_Entity // Enherit the class
    {
        public string Name { get; set; }    // Model
        public int Default_Days { get; set; }
        
    }
}
