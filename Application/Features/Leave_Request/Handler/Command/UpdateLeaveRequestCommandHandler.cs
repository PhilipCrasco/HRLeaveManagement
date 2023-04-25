using Application.Features.Leave_Request.Request.Command;
using Application.Persistance.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Request.Handler.Command
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _LeaveRequestRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository LeaveRequestRepository, IMapper mapper)
        {
            _LeaveRequestRepository = LeaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {

            var leaveRequest = await _LeaveRequestRepository.Get(request.Id);

            if (request.LeaveRequestDto != null)
            {

              
                _mapper.Map(request.LeaveRequestDto, leaveRequest);

                await _LeaveRequestRepository.Update(leaveRequest);

            }
            else if(request.changeLeaveRequestApprovalDto != null) 
            {

                await _LeaveRequestRepository.Change_Approval_Status(leaveRequest, request.changeLeaveRequestApprovalDto.Approved); //Get The Interface
            }

            return Unit.Value;




        }
    }
}
