using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS.LeaveMangement.Application.DTOs.Common;
using DBS.LeaveMangement.Application.DTOs.LeaveTypeDtos;

namespace DBS.LeaveMangement.Application.DTOs.LeaveAllocationDtos
{
    public class LeaveAllocationDto : BaseDto
    {

        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }

    }
}
