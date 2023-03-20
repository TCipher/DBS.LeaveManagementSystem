using DBS.LeaveMangement.Application.DTOs.Common;
using DBS.LeaveMangement.Application.DTOs.LeaveTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveMangement.Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
      
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
