using Grpc.Core;
using UserGrpc;

namespace GrpcServiceServer.Services;

public class UserService : UserOperation.UserOperationBase
{
    public override Task<UserCreateResponse> UserCreate(UserCreateRequest request, ServerCallContext context)
    {
        return Task.FromResult(new UserCreateResponse()
        {
            Id = request.Id,
            Name = request.Name,
            Surname = request.Surname
        });
    }

    public override Task<UserGreetResponse> UserGreet(UserCreateRequest request, ServerCallContext context)
    {
        var nameSurname = request.Name + " - " + request.Surname;
        return Task.FromResult(new UserGreetResponse()
        {
            Message = "Hello dear " + nameSurname
        });
    }
}