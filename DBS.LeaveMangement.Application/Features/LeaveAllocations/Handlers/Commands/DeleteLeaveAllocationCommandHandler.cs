using AutoMapper;
using DBS.LeaveMangement.Application.Features.LeaveRequests.Request.Commands;
using DBS.LeaveMangement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.Features.LeaveAllocations.Handlers.Commands
{
    
        public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
        {
            private readonly ILeaveAllocationRepository _leaveAllocationRepository;
            private readonly IMapper _mapper;

            public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
            {
            _leaveAllocationRepository = leaveAllocationRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
            {
                var leaveAllocation = await _leaveAllocationRepository.GetAsync(request.Id);
            await _leaveAllocationRepository.DeleteAsync(leaveAllocation);

                return Unit.Value;
            }
        }
    }

