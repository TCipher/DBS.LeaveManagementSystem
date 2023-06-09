﻿using AutoMapper;
using DBS.LeaveManagement.Domain;
using DBS.LeaveMangement.Application.DTOs.LeaveRequest;
using DBS.LeaveMangement.Application.Features.LeaveRequests.Request.Queries;
using DBS.LeaveMangement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestListDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository,
           IMapper mapper
          )
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
          
        }
        public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
           var   leaveRequests = await _leaveRequestRepository.GetLeaveRequestsWithDetails();
           return _mapper.Map<List<LeaveRequestListDto>>(leaveRequests);
        }
    }
}
