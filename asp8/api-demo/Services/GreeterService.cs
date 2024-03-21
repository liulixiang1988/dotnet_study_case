using api_demo.Grpc.Protos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace api_demo.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<AnyTypeGrpcResponse> SayHello(HelloRequest request, ServerCallContext context)
    {
        var grpcResponse = new AnyTypeGrpcResponse();
        grpcResponse.Results.Add("key1", Any.Pack(new StringValue{Value="hello"}));
        grpcResponse.Results.Add("key2", Any.Pack(new Int32Value{Value=123}));
        grpcResponse.Results.Add("key3", Any.Pack(new HelloReply{Message = "hello"}));
        return Task.FromResult(grpcResponse);
    }
}