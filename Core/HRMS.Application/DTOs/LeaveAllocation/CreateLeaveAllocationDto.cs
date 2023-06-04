using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS.Application.DTOs.Common;
using HRMS.Application.DTOs.LeaveAllocation;

namespace HRMS.Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDto
    {
        public int LeaveTypeId { get; set; }
    }
}