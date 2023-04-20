using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistance.Contracts
{
    public interface ILeave_Request_Repository : IGenericRepository<Leave_Request>
    {

        Task<Leave_Request> Get_Leave_Request_With_Details(int Id);
        Task<List<Leave_Request>> Get_Leave_Requests_With_Details();

    }
}
