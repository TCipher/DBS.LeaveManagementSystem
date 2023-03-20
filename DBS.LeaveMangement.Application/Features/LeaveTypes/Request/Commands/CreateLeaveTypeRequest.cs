using DBS.LeaveMangement.Application.DTOs.LeaveTypeDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.Features.LeaveTypes.Request.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
       public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
