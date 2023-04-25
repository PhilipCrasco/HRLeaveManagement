using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistance.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {

        Task<LeaveRequest> Get_Leave_Request_With_Details(int Id);
        Task<List<LeaveRequest>> Get_Leave_Requests_With_Details();
        Task Change_Approval_Status(LeaveRequest leaveRequest, bool? ApprovalStatus);

    }
}
