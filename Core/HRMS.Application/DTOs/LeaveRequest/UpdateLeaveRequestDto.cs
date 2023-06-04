using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS.Application.DTOs.Common;

namespace HRMS.Application.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDto : BaseDto, ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
        public bool Cancelled { get; set; }
    }
}