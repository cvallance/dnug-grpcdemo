using System;
using System.Threading.Tasks;
using DNUG.GrpcDemo;
using Grpc.Core;

namespace DNUG.GrpcDemoServer
{
    public class GrpcDemoServerImpl : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Request: {request.Name}");
            
            return Task.FromResult(new HelloReply
            {
                Message = $"Hello {request.Name}"
            });
        }

        public override Task<HelloReply> SayHelloAgain(HelloRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Request: {request.Name}");
            
            return Task.FromResult(new HelloReply
            {
                Message = $"Hello again {request.Name}"
            });
        }
    }
}