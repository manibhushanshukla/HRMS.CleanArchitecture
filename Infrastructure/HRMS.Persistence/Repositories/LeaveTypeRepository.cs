using HRMS.Application.Contracts.Persistence;
using HRMS.Domain;
using System;
using System.Collections.Generic;
using System.Text;
namespace HRMS.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}