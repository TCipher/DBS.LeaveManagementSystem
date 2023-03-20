using DBS.LeaveMangement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto: BaseDto
    {
        public bool? Approved { get; set; }
    }
}
