using System.ComponentModel.DataAnnotations.Schema;

namespace HSUrlaubsPlaner.GrpcService.Data.Models;

public class LeaveRequest
{
    public int LeaveRequestId { get; set; }
    public int? RequesterId { get; set; }

    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public eLeaveType LeaveType { get; set; } = eLeaveType.Urlaub;
    public DateTimeOffset DateRequested { get; set; }
    public DateTimeOffset DateActioned { get; set; } = default;
    public bool Approved { get; set; }
    public int? ApproverId { get; set; }
    public bool Canceled { get; set; }
    public string Comment { get; set; } = "";
    

    [ForeignKey(nameof(RequesterId))]
    public virtual Employee? Requester { get; set; }

    [ForeignKey(nameof(ApproverId))] 
    public virtual Employee? Approver { get; set; }
}
