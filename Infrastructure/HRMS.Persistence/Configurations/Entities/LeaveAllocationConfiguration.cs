using HRMS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HRMS.Persistence.Configurations.Entities
{
    public class LeaveAllocationConfiguration : IEntityTypeConfiguration<LeaveAllocation>
    {
        public void Configure(EntityTypeBuilder<LeaveAllocation> builder)
        {
            
        }
    }
}