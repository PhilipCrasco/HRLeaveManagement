using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistance.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType> // Interface
    {

        Task<LeaveType> Get_Leave_Type_With_Details(int Id);
        Task<List<LeaveType>> Get_Leave_Types_With_Details();

    }
}
