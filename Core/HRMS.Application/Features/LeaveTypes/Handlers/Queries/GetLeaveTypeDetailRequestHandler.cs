using AutoMapper;
using HRMS.Application.DTOs;
using HRMS.Application.DTOs.LeaveType;
using HRMS.Application.Features.LeaveRequests.Requests.Queries;
using HRMS.Application.Features.LeaveTypes.Requests;
using HRMS.Application.Features.LeaveTypes.Requests.Queries;
using HRMS.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRMS.Application.Features.LeaveTypes.Handlers.Queries
{
   public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}