using Application.Features.Leave_Types.Request.Command;
using Application.Persistance.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Leave_Types.Handler.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _Leave_Type_Repository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leave_Type_Repository, IMapper mapper)
        {
            _Leave_Type_Repository = leave_Type_Repository;
            _mapper = mapper;

        }


        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leavetype = await _Leave_Type_Repository.Get(request.LeaveTypeDto.Id);

            _mapper.Map(request.LeaveTypeDto, leavetype);

            await _Leave_Type_Repository.Update(leavetype);

            return Unit.Value;
        }
    }
}
