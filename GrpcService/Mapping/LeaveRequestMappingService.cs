using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;
using HSUrlaubsPlaner.GrpcService.Data.Models;

namespace HSUrlaubsPlaner.GrpcService.Mapping;

public class LeaveRequestMappingService : IMappingService<LeaveRequest, LeaveRequestDto>
{
    private readonly EmployeeMappingService _employeeMapper;

    public LeaveRequestMappingService(EmployeeMappingService employeeMapper)
    {
        _employeeMapper = employeeMapper;
    }

    public LeaveRequestDto ToDto(LeaveRequest e)
    {
        return new LeaveRequestDto
        {
            Approved = e.Approved,
            Approver = _employeeMapper.ToDto(e.Approver),
            Canceled = e.Canceled,
            Comment = e.Comment,
            DateActioned = Timestamp.FromDateTimeOffset(e.DateActioned),
            DateRequested = Timestamp.FromDateTimeOffset(e.DateRequested),
            EndDate = Timestamp.FromDateTimeOffset(e.EndDate),
            Id = e.LeaveRequestId,
            LeaveType = e.LeaveType,
            Requester = _employeeMapper.ToDto(e.Requester),
            StartDate = Timestamp.FromDateTimeOffset(e.StartDate)
        };
    }

   

    public LeaveRequest ToEntity(LeaveRequestDto d)
    {
        throw new NotImplementedException();
    }

   
}