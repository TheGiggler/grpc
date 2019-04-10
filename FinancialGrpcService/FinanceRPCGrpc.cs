// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinanceRPC.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Financial {
  public static partial class FinancialTransaction
  {
    static readonly string __ServiceName = "financial.FinancialTransaction";

    static readonly grpc::Marshaller<global::Financial.TransactionRequest> __Marshaller_financial_TransactionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Financial.TransactionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Financial.TransactionResponse> __Marshaller_financial_TransactionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Financial.TransactionResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Financial.TransactionRequest, global::Financial.TransactionResponse> __Method_ProcessTransaction = new grpc::Method<global::Financial.TransactionRequest, global::Financial.TransactionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ProcessTransaction",
        __Marshaller_financial_TransactionRequest,
        __Marshaller_financial_TransactionResponse);

    static readonly grpc::Method<global::Financial.TransactionRequest, global::Financial.TransactionResponse> __Method_ProcessTransactionStream = new grpc::Method<global::Financial.TransactionRequest, global::Financial.TransactionResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ProcessTransactionStream",
        __Marshaller_financial_TransactionRequest,
        __Marshaller_financial_TransactionResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Financial.FinanceRPCReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FinancialTransaction</summary>
    public abstract partial class FinancialTransactionBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Financial.TransactionResponse> ProcessTransaction(global::Financial.TransactionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task ProcessTransactionStream(grpc::IAsyncStreamReader<global::Financial.TransactionRequest> requestStream, grpc::IServerStreamWriter<global::Financial.TransactionResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FinancialTransaction</summary>
    public partial class FinancialTransactionClient : grpc::ClientBase<FinancialTransactionClient>
    {
      /// <summary>Creates a new client for FinancialTransaction</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FinancialTransactionClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FinancialTransaction that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FinancialTransactionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FinancialTransactionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FinancialTransactionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Financial.TransactionResponse ProcessTransaction(global::Financial.TransactionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ProcessTransaction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Financial.TransactionResponse ProcessTransaction(global::Financial.TransactionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ProcessTransaction, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Financial.TransactionResponse> ProcessTransactionAsync(global::Financial.TransactionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ProcessTransactionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Financial.TransactionResponse> ProcessTransactionAsync(global::Financial.TransactionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ProcessTransaction, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Financial.TransactionRequest, global::Financial.TransactionResponse> ProcessTransactionStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ProcessTransactionStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Financial.TransactionRequest, global::Financial.TransactionResponse> ProcessTransactionStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ProcessTransactionStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FinancialTransactionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FinancialTransactionClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FinancialTransactionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ProcessTransaction, serviceImpl.ProcessTransaction)
          .AddMethod(__Method_ProcessTransactionStream, serviceImpl.ProcessTransactionStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FinancialTransactionBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ProcessTransaction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Financial.TransactionRequest, global::Financial.TransactionResponse>(serviceImpl.ProcessTransaction));
      serviceBinder.AddMethod(__Method_ProcessTransactionStream, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Financial.TransactionRequest, global::Financial.TransactionResponse>(serviceImpl.ProcessTransactionStream));
    }

  }
}
#endregion
