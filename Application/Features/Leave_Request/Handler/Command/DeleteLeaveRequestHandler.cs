using Application.Features.Leave_Request.Request.Command;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Request.Handler.Command
{
    public class DeleteLeaveRequestHandler : IRequestHandler<DeleteLeaveRequestCommand>
    {

        private readonly ILeaveRequestRepository _LeaveRequestRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveRequestHandler(ILeaveRequestRepository LeaveRequestRepository, IMapper mapper)
        {
            _LeaveRequestRepository = LeaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaverequest = await _LeaveRequestRepository.Get(request.Id);

            await _LeaveRequestRepository.Delete(leaverequest);

            return Unit.Value;
        }
    }
}
