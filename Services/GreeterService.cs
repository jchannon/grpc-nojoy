// using Grpc.Core;
// using GrpcGreeter;


using GrpcGreeter;

namespace GrpcGreeter.Services;
//
// public class GreeterService : Greeter.GreeterBase
// {
//     private readonly ILogger<GreeterService> _logger;
//     public GreeterService(ILogger<GreeterService> logger)
//     {
//         _logger = logger;
//     }
//
//     public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
//     {
//         return Task.FromResult(new HelloReply
//         {
//             Message = "Hello " + request.Name,
//             Age = 12,
//             //Name = request.Name
//             Corpus = HelloReply.Types.Corpus.Products
//         });
//     }
// }


//using GrpcGreeter;
using ProtoBuf.Grpc;

public class GreeterService : IGreeter
{
    public ValueTask<HelloReply> SayHelloAsync(HelloRequest request, CallContext context = default)
    {
        return ValueTask.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name,
            Age = 12,
            //Name = request.Name
            corpus = HelloReply.Corpus.Video
        });
    }
}