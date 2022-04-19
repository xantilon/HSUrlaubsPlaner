
using HSUrlaubsPlaner.GrpcService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HSUrlaubsPlaner.GrpcService.Data;

public class LeaveRequestContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HSUrlaubsPlaner;Trusted_Connection=True");

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<LeaveRequest> LeaveRequests => Set<LeaveRequest>();
    public DbSet<LeaveAllocation> LeaveAllocations => Set<LeaveAllocation>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        
        
        modelBuilder.Entity<Employee>().HasData(new Employee
        {
            EmployeeId = 1,
            Name = "Edgar Holzke",
            Email = @"e.holzke@hamann-software.de",
            DateOfEntry = new DateTimeOffset(new DateTime(2017, 6, 6), TimeSpan.FromHours(2)),
            MaxLeaveDays = 27
        },
        new Employee
        {
            EmployeeId = 2,
            Name = "Bruce Wayne",
            Email = @"b.atman@hamann-software.de",
            DateOfEntry = new DateTimeOffset(DateTime.Now.AddDays(-7), TimeSpan.FromHours(2)),
            MaxLeaveDays = 27
        });


        modelBuilder.Entity<LeaveRequest>().HasData(
            new LeaveRequest {
                LeaveRequestId = 1,
                RequesterId = 1,
                DateRequested = DateTimeOffset.Parse("2022-04-02"),
                LeaveType = eLeaveType.Urlaub,
                StartDate = DateTimeOffset.Parse("2022-05-02"),
                EndDate = DateTimeOffset.Parse("2022-05-04")
            },
            new LeaveRequest
            {
                LeaveRequestId = 2,
                RequesterId = 2,
                DateRequested = DateTimeOffset.Parse("2022-04-02"),
                LeaveType = eLeaveType.Urlaub,
                StartDate = DateTimeOffset.Parse("2022-05-02"),
                EndDate = DateTimeOffset.Parse("2022-05-04")
            }

            );       
    }
}