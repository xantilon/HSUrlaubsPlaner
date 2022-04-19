using HSUrlaubsPlaner.GrpcService.Data;
using HSUrlaubsPlaner.GrpcService.Services;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Authentication..Negotiate;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddDbContext<LeaveRequestContext>();

var app = builder.Build();

// migrate any database changes on startup (includes initial db creation)
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<LeaveRequestContext>();
    dataContext.Database.Migrate();
}

// app.UseRouting();
// app.UseAuthentication();
// app.UseAuthorization();
// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapGrpcService<LeaveRequestService>();
// });
app.MapGrpcService<LeaveRequestService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
app.Run();
