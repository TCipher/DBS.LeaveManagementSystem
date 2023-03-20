using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS.LeaveMangement.Application.DTOs.Common;
using DBS.LeaveMangement.Application.DTOs.LeaveTypeDtos;

namespace DBS.LeaveMangement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto: BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }


    }
}
