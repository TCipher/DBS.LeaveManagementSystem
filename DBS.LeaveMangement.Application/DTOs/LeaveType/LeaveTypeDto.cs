using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS.LeaveMangement.Application.DTOs.Common;

namespace DBS.LeaveMangement.Application.DTOs.LeaveTypeDtos
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
