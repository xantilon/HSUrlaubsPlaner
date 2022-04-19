using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;
using HSUrlaubsPlaner.GrpcService.Data.Models;

namespace HSUrlaubsPlaner.GrpcService.Mapping;

public class LeaveAllocationMappingService : IMappingService<LeaveAllocation, LeaveAllocationDto>
{
    private readonly EmployeeMappingService employeeMapper;
    public LeaveAllocationMappingService(EmployeeMappingService employeeMapper)
    {
        this.employeeMapper = employeeMapper;
    }
    public LeaveAllocationDto ToDto(LeaveAllocation? e)
    {
        LeaveAllocation l = e ?? new LeaveAllocation();
        Employee esave = l.Employee ?? new Employee();
        return new LeaveAllocationDto
        {
            Employee = employeeMapper.ToDto(l.Employee),
            EndDate = Timestamp.FromDateTimeOffset(l.EndDate),
            Id = l.LeaveAllocationId,
            LeaveRequestId = l.LeaveRequestId ?? 0,
            LeaveType = l.LeaveType,
            NumberOfDays = l.NumberOfDays,
            StartDate = Timestamp.FromDateTimeOffset(l.StartDate)
        };
    }

    public LeaveAllocation ToEntity(LeaveAllocationDto d)
    {
        return new LeaveAllocation
        {
            Employee = employeeMapper.ToEntity(d.Employee),
            EndDate = d.EndDate.ToDateTimeOffset(),
            LeaveAllocationId = d.Id,
            LeaveRequestId = d.LeaveRequestId,
            LeaveType = d.LeaveType,
            NumberOfDays = d.NumberOfDays,
            StartDate = d.StartDate.ToDateTimeOffset()
        };
    }
}