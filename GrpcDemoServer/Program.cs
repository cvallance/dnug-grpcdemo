using System;
using Grpc.Core;

namespace DNUG.GrpcDemoServer
{
    class Program
    {
        private const int Port = 50052;
        
        static void Main(string[] args)
        {
            var server = new Server
            {
                Services = { GrpcDemo.Greeter.BindService(new GrpcDemoServerImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine($"Server started, listening on port {Port}");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}