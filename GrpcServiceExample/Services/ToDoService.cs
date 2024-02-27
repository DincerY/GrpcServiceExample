using Grpc.Core;
using ToDoGrpc;

namespace GrpcServiceServer.Services;

public class ToDoService : ToDoIt.ToDoItBase
{
    private readonly ILogger<ToDoService> _logger;

    public ToDoService(ILogger<ToDoService> logger)
    {
        _logger = logger;
    }

    public override Task<CreateToDoResponse> CreateToDo(CreateToDoRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CreateToDoResponse() { Id = 1 });
    }

    public override Task<DeleteToDoResponse> DeleteToDo(DeleteToDoRequest request, ServerCallContext context)
    {
        return Task.FromResult(new DeleteToDoResponse() { Id = 1});
    }

    public override Task<GetAllResponse> ListToDo(GetAllRequest request, ServerCallContext context)
    {
        return Task.FromResult(new GetAllResponse() { Id = 1, Description = "asasda", Title = "asda", ToDoStatus = "asdd"});
    }

    public override Task<ReadToDoResponse> ReadToDo(ReadToDoRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ReadToDoResponse() { Id = 1, Description = "asasda", Title = "asda", ToDoStatus = "asdd" });
    }

    public override Task<UpdateToDoResponse> UpdateToDo(UpdateToDoRequest request, ServerCallContext context)
    {
        return Task.FromResult(new UpdateToDoResponse() { Id = 1 });
    }
}