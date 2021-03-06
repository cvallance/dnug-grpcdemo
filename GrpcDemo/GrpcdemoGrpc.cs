// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grpcdemo.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DNUG.GrpcDemo {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "GrpcDemo.Greeter";

    static readonly grpc::Marshaller<global::DNUG.GrpcDemo.HelloRequest> __Marshaller_GrpcDemo_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DNUG.GrpcDemo.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::DNUG.GrpcDemo.HelloReply> __Marshaller_GrpcDemo_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DNUG.GrpcDemo.HelloReply.Parser.ParseFrom);

    static readonly grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> __Method_SayHello = new grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_GrpcDemo_HelloRequest,
        __Marshaller_GrpcDemo_HelloReply);

    static readonly grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> __Method_SayHelloAgain = new grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHelloAgain",
        __Marshaller_GrpcDemo_HelloRequest,
        __Marshaller_GrpcDemo_HelloReply);

    static readonly grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> __Method_LotsOfReplies = new grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "LotsOfReplies",
        __Marshaller_GrpcDemo_HelloRequest,
        __Marshaller_GrpcDemo_HelloReply);

    static readonly grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> __Method_LotsOfGreetings = new grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "LotsOfGreetings",
        __Marshaller_GrpcDemo_HelloRequest,
        __Marshaller_GrpcDemo_HelloReply);

    static readonly grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> __Method_LotsOfEverything = new grpc::Method<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "LotsOfEverything",
        __Marshaller_GrpcDemo_HelloRequest,
        __Marshaller_GrpcDemo_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DNUG.GrpcDemo.GrpcdemoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    public abstract partial class GreeterBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::DNUG.GrpcDemo.HelloReply> SayHello(global::DNUG.GrpcDemo.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Sends another greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::DNUG.GrpcDemo.HelloReply> SayHelloAgain(global::DNUG.GrpcDemo.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task LotsOfReplies(global::DNUG.GrpcDemo.HelloRequest request, grpc::IServerStreamWriter<global::DNUG.GrpcDemo.HelloReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DNUG.GrpcDemo.HelloReply> LotsOfGreetings(grpc::IAsyncStreamReader<global::DNUG.GrpcDemo.HelloRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task LotsOfEverything(grpc::IAsyncStreamReader<global::DNUG.GrpcDemo.HelloRequest> requestStream, grpc::IServerStreamWriter<global::DNUG.GrpcDemo.HelloReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Greeter</summary>
    public partial class GreeterClient : grpc::ClientBase<GreeterClient>
    {
      /// <summary>Creates a new client for Greeter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreeterClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Greeter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreeterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreeterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreeterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DNUG.GrpcDemo.HelloReply SayHello(global::DNUG.GrpcDemo.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DNUG.GrpcDemo.HelloReply SayHello(global::DNUG.GrpcDemo.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DNUG.GrpcDemo.HelloReply> SayHelloAsync(global::DNUG.GrpcDemo.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DNUG.GrpcDemo.HelloReply> SayHelloAsync(global::DNUG.GrpcDemo.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>
      /// Sends another greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DNUG.GrpcDemo.HelloReply SayHelloAgain(global::DNUG.GrpcDemo.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAgain(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends another greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::DNUG.GrpcDemo.HelloReply SayHelloAgain(global::DNUG.GrpcDemo.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHelloAgain, null, options, request);
      }
      /// <summary>
      /// Sends another greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DNUG.GrpcDemo.HelloReply> SayHelloAgainAsync(global::DNUG.GrpcDemo.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAgainAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends another greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::DNUG.GrpcDemo.HelloReply> SayHelloAgainAsync(global::DNUG.GrpcDemo.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHelloAgain, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::DNUG.GrpcDemo.HelloReply> LotsOfReplies(global::DNUG.GrpcDemo.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LotsOfReplies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::DNUG.GrpcDemo.HelloReply> LotsOfReplies(global::DNUG.GrpcDemo.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_LotsOfReplies, null, options, request);
      }
      public virtual grpc::AsyncClientStreamingCall<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> LotsOfGreetings(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LotsOfGreetings(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> LotsOfGreetings(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_LotsOfGreetings, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> LotsOfEverything(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LotsOfEverything(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::DNUG.GrpcDemo.HelloRequest, global::DNUG.GrpcDemo.HelloReply> LotsOfEverything(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_LotsOfEverything, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GreeterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreeterClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_SayHelloAgain, serviceImpl.SayHelloAgain)
          .AddMethod(__Method_LotsOfReplies, serviceImpl.LotsOfReplies)
          .AddMethod(__Method_LotsOfGreetings, serviceImpl.LotsOfGreetings)
          .AddMethod(__Method_LotsOfEverything, serviceImpl.LotsOfEverything).Build();
    }

  }
}
#endregion
