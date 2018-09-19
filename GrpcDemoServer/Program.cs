using System;
using System.Threading.Tasks;
using Grpc.Core;

namespace DNUG.GrpcDemoServer
{
    class Program
    {
        private const int Port = 50052;
        
        static async Task Main(string[] args)
        {
            var server = new Server
            {
                Services = { GrpcDemo.Greeter.BindService(new GrpcDemoServerImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine($"Server started, listening on port {Port}");
            Console.ReadKey();

            Console.WriteLine("Server shutting down");
            await server.ShutdownAsync();
        }
    }
}