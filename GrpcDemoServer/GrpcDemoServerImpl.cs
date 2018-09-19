using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNUG.GrpcDemo;
using Grpc.Core;

namespace DNUG.GrpcDemoServer
{
    public class GrpcDemoServerImpl : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            Console.WriteLine($"SayHello: {request.Name}");
            
            return Task.FromResult(new HelloReply
            {
                Message = $"Hello {request.Name}"
            });
        }

        public override Task<HelloReply> SayHelloAgain(HelloRequest request, ServerCallContext context)
        {
            Console.WriteLine($"SayHelloAgain: {request.Name}");
            
            return Task.FromResult(new HelloReply
            {
                Message = $"Hello again {request.Name}"
            });
        }

        public override async Task LotsOfReplies(HelloRequest request, IServerStreamWriter<HelloReply> responseStream, ServerCallContext context)
        {
            Console.WriteLine($"LotsOfReplies: {request.Name}");
            
            var responses = CreateReplies(request);
            foreach (var response in responses)
            {
                Console.WriteLine($"Sending response: {response.Message}");
                await responseStream.WriteAsync(response);
            }
        }

        public override async Task<HelloReply> LotsOfGreetings(IAsyncStreamReader<HelloRequest> requestStream, ServerCallContext context)
        {
            Console.WriteLine("LotsOfGreetings");

            var names = new List<string>();
            while (await requestStream.MoveNext())
            {
                var request = requestStream.Current;
                Console.WriteLine($"Request: {request.Name}");
                names.Add(request.Name);
            }

            return new HelloReply {Message = $"Hello {string.Join(", ", names)}"};
        }

        public override async Task LotsOfEverything(IAsyncStreamReader<HelloRequest> requestStream, IServerStreamWriter<HelloReply> responseStream, ServerCallContext context)
        {
            Console.WriteLine("LotsOfEverything");

            while (await requestStream.MoveNext())
            {
                var request = requestStream.Current;
                Console.WriteLine($"Request: {request.Name}");

                var responses = CreateReplies(request);
                foreach (var response in responses)
                {
                    Console.WriteLine($"Sending response: {response.Message}");
                    await responseStream.WriteAsync(response);
                }
            }
        }

        private IEnumerable<HelloReply> CreateReplies(HelloRequest request)
        {
            return new List<HelloReply>
            {
                new HelloReply {Message = $"Hello {request.Name}"},
                new HelloReply {Message = $"How are you {request.Name}?"},
                new HelloReply {Message = $"Well, I hope you're doing well {request.Name}"}
            };
        }
    }
}