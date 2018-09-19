using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNUG.GrpcDemo;
using Grpc.Core;

namespace DNUG.GrpcDemoClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = new Channel("127.0.0.1:50052", ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);
            
//            await SayHelloAsync(client);
//            await SayHelloAgainAsync(client);
//            await LotsOfReplies(client);
            await LotsOfGreetings(client);
            await LotsOfEverything(client);
        }

        private static async Task SayHelloAsync(Greeter.GreeterClient client)
        {
            Console.WriteLine("SayHello");

            var res = await client.SayHelloAsync(new HelloRequest {Name = "Garry"});
            
            Console.WriteLine($"Response: {res.Message}");
        }
        
        private static async Task SayHelloAgainAsync(Greeter.GreeterClient client)
        {
            Console.WriteLine("SayHelloAgain");

            var res = await client.SayHelloAgainAsync(new HelloRequest {Name = "Garry"});
            
            Console.WriteLine($"Response: {res.Message}");
        }
        
        private static async Task LotsOfReplies(Greeter.GreeterClient client)
        {
            Console.WriteLine("LotsOfReplies");

            using (var call = client.LotsOfReplies(new HelloRequest {Name = "Garry"}))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var res = call.ResponseStream.Current;
                    Console.WriteLine($"Response: {res.Message}");
                }
            }
        }
        
        private static async Task LotsOfGreetings(Greeter.GreeterClient client)
        {
            Console.WriteLine("LotsOfGreetings");

            using (var call = client.LotsOfGreetings())
            {
                var requests = GetRequests();
                foreach (var request in requests)
                {
                    Console.WriteLine($"Request: {request.Name}");
                    await call.RequestStream.WriteAsync(request);
                }

                await call.RequestStream.CompleteAsync();

                var res = await call.ResponseAsync;
                Console.WriteLine($"Response: {res.Message}");
            }
        }
        
        private static async Task LotsOfEverything(Greeter.GreeterClient client)
        {
            Console.WriteLine("LotsOfEverything");
            
            using (var call = client.LotsOfEverything())
            {
                var responseReaderTask = Task.Run(async () =>
                {
                    // ReSharper disable AccessToDisposedClosure
                    while (await call.ResponseStream.MoveNext())
                    {
                        var res = call.ResponseStream.Current;
                        Console.WriteLine($"Response: {res.Message}");
                    }
                    // ReSharper restore AccessToDisposedClosure
                });

                var requests = GetRequests();
                foreach (var request in requests)
                {
                    Console.WriteLine($"Request: {request.Name}");
                    await call.RequestStream.WriteAsync(request);
                }
                await call.RequestStream.CompleteAsync();
                await responseReaderTask;
            }
        }

        private static IEnumerable<HelloRequest> GetRequests()
        {
            return new List<HelloRequest>
            {
                new HelloRequest { Name = "Barry"},
                new HelloRequest { Name = "Susan"},
                new HelloRequest { Name = "Basuarryan"}
            };
        }
    }
}