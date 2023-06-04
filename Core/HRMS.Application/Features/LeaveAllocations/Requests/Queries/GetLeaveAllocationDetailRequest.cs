using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS.Application.DTOs;
using HRMS.Application.DTOs.LeaveAllocation;
using HRMS.Application.DTOs.LeaveRequest;
using MediatR;

namespace HRMS.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}