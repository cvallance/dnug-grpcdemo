using System;
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
            
            await SayHelloAsync(client);
            await SayHelloAgainAsync(client);
        }

        private static async Task SayHelloAsync(Greeter.GreeterClient client)
        {
            Console.WriteLine("SayHello");
            
            var res = await client.SayHelloAsync(new HelloRequest
            {
                Name = "Garry"
            });
            
            Console.WriteLine($"Response: {res.Message}");
        }
        
        private static async Task SayHelloAgainAsync(Greeter.GreeterClient client)
        {
            Console.WriteLine("SayHelloAgain");
            
            var res = await client.SayHelloAgainAsync(new HelloRequest
            {
                Name = "Garry"
            });
            
            Console.WriteLine($"Response: {res.Message}");
        }
    }
}