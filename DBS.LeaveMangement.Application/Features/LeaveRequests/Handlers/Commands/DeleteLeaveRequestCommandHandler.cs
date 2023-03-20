﻿using AutoMapper;
using DBS.LeaveMangement.Application.Features.LeaveRequests.Request.Commands;
using DBS.LeaveMangement.Application.Features.LeaveTypes.Request.Commands;
using DBS.LeaveMangement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveRequestRepository.GetAsync(request.Id);
            await _leaveRequestRepository.DeleteAsync(leaveType);
            return Unit.Value;
        }
    }
}
