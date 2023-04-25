using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LeaveType : BaseDomainEntity // Enherit the class
    {
        public string Name { get; set; }    // Model
        public int DefaultDays { get; set; }
        
    }
}
