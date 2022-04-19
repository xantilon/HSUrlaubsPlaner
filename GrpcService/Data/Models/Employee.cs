namespace HSUrlaubsPlaner.GrpcService.Data.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = "Max Mustermann";
        public string Email { get; set; } = "m.mustermann@hamann-software.de";
        public DateTimeOffset DateOfEntry { get; set; } = new DateTimeOffset();
        public int MaxLeaveDays { get; set; } = 27;
    }
}