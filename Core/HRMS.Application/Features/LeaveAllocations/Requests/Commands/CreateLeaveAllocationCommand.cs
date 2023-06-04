using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS.Application.DTOs.LeaveAllocation;
using HRMS.Application.DTOs.LeaveType;
using HRMS.Application.Responses;
using MediatR;

namespace HRMS.Application.Features.LeaveAllocations.Requests.Commands
{
     public class CreateLeaveAllocationCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}