using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSUrlaubsPlaner.GrpcService.Data.Models
{
    public class LeaveAllocation
    {


        public int LeaveAllocationId { get; set; }
        public float NumberOfDays {get;set;}
        public int? LeaveRequestId {get;set;}

        public int? EmployeeId { get; set; }


        public eLeaveType LeaveType {get;set;}
        public DateTimeOffset StartDate {get;set;}
        public DateTimeOffset EndDate {get;set;}


        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee? Employee { get; set; }

        //private Employee? _employee;
        //[BackingField(nameof(_employee))]
        //public Employee Employee 
        //{
        //    get => _employee
        //            ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Employee));
        //    set => _employee = value;
        //}

    }
}