using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace HRMS.Application.Features.LeaveRequests.Requests.Commands
{
   public class DeleteLeaveRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}