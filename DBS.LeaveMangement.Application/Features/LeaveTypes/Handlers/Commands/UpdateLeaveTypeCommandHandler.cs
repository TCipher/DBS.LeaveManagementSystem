﻿using AutoMapper;
using DBS.LeaveMangement.Application.Features.LeaveTypes.Request.Commands;
using DBS.LeaveMangement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetAsync(request.LeaveTypeDto.Id);
            _mapper.Map(request.LeaveTypeDto, leaveType);
            await _leaveTypeRepository.UpdateAsync(leaveType);
            return Unit.Value;
        }
    }
}
