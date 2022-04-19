using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;
using HSUrlaubsPlaner.GrpcService.Data.Models;

namespace HSUrlaubsPlaner.GrpcService.Mapping;

public class EmployeeMappingService : IMappingService<Employee, EmployeeDto>
{
    public EmployeeDto ToDto(Employee? e)
    {
        Employee esave = e ?? new Employee();
        return new EmployeeDto
        {
            DateOfEntry = Timestamp.FromDateTimeOffset(esave.DateOfEntry),
            Email = esave.Email,
            Id = esave.EmployeeId,
            MaxLeaveDays = esave.MaxLeaveDays,
            Name = esave.Name
        };
    }

    public Employee ToEntity(EmployeeDto d)
    {
        return new Employee
        {
            DateOfEntry = d.DateOfEntry.ToDateTimeOffset(),
            Email = d.Email,
            EmployeeId = d.Id,
            MaxLeaveDays = d.MaxLeaveDays,
            Name = d.Name
        };
    }
}