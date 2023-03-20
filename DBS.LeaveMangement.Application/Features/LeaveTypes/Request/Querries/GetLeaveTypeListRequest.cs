using DBS.LeaveMangement.Application.DTOs.LeaveTypeDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.Features.Request.Querries
{
    public class GetLeaveTypeListRequest: IRequest<List<LeaveTypeDto>>
    {
    }
}
