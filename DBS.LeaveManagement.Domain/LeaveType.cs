﻿using DBS.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS.LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
     
        public string Name { get; set; }
        public int DefaultDays { get; set; }
      
    }
}
