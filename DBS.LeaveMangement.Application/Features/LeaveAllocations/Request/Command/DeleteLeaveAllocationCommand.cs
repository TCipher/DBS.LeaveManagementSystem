using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.Features.LeaveAllocations.Request.Command
{
    public class DeleteLeaveAllocationCommand:IRequest
    {
        public int Id { get; set; }
    }
}
