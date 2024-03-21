using api_demo.Grpc.Protos;
using api_demo.Models;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;

namespace api_demo.Controllers;

[ApiController]
public class AnyDataDemoController: ControllerBase
{
    [HttpGet("anyDataDemo")]
    //[ProducesResponseType(200, Type = typeof())]
    public async Task<IActionResult> AnyDataDemoAsync()
    {
        AnyTypeResponse response = new AnyTypeResponse();
        AnyTypeGrpcResponse grpcResponse = new AnyTypeGrpcResponse();
        grpcResponse.Results.Add("key1", Any.Pack(new StringValue{Value="hello"}));
        grpcResponse.Results.Add("key2", Any.Pack(new Int32Value{Value=123}));
        grpcResponse.Results.Add("key3", Any.Pack(new HelloReply{Message = "hello"}));

        foreach (var grpcResponseResult in grpcResponse.Results)
        {
            response.Output.Add(grpcResponseResult.Key, grpcResponseResult.Value.ToString());
            response.Output.Add(grpcResponseResult.Key+"-type", grpcResponseResult.Value.TypeUrl);
        }
        response.Output.Add("key4", new HelloReply{Message = "hello"});
        response.Output.Add("key5", new Int32Value{Value=123});
        return await Task.FromResult(Ok(response));
    }
}