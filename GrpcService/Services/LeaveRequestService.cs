using Grpc.Core;
using HSUrlaubsPlaner.GrpcService;

namespace HSUrlaubsPlaner.GrpcService.Services;

public class LeaveRequestService : Leaves.LeavesBase
{
    private readonly ILogger<LeaveRequestService> _logger;
    public LeaveRequestService(ILogger<LeaveRequestService> logger)
    {
        _logger = logger;
    }

   
}
