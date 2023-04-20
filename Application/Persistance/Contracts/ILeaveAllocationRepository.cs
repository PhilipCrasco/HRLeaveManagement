using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistance.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> Get_Leave_Allocation_With_Details(int Id);
        Task<List<LeaveAllocation>> Get_Leave_Allocations_With_Details();

    }
}
