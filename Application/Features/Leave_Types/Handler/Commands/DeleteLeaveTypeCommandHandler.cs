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
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand>
    {

        private readonly ILeaveTypeRepository _Leave_Type_Repository;
        private readonly IMapper _mapper;

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leave_Type_Repository, IMapper mapper)
        {
            _Leave_Type_Repository = leave_Type_Repository;
            _mapper = mapper;

        }



        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leavetype = await _Leave_Type_Repository.Get(request.Id);

            await _Leave_Type_Repository.Delete(leavetype);

            return Unit.Value;
        }
    }
}
