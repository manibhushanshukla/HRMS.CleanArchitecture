using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace HRMS.Application.Features.LeaveTypes.Requests.Commands
{
   public class DeleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}