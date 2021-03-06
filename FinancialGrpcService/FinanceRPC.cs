// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinanceRPC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Financial {

  /// <summary>Holder for reflection information generated from FinanceRPC.proto</summary>
  public static partial class FinanceRPCReflection {

    #region Descriptor
    /// <summary>File descriptor for FinanceRPC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinanceRPCReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBGaW5hbmNlUlBDLnByb3RvEglmaW5hbmNpYWwijwEKElRyYW5zYWN0aW9u",
            "UmVxdWVzdBIRCglBY2NvdW50SUQYASABKAkSDgoGQW1vdW50GAIgASgBEigK",
            "BFR5cGUYAyABKA4yGi5maW5hbmNpYWwuVHJhbnNhY3Rpb25UeXBlEiwKBlN0",
            "YXR1cxgEIAEoDjIcLmZpbmFuY2lhbC5UcmFuc2FjdGlvblN0YXR1cyLAAQoT",
            "VHJhbnNhY3Rpb25SZXNwb25zZRIRCglBY2NvdW50SUQYASABKAkSDgoGQW1v",
            "dW50GAIgASgBEigKBFR5cGUYAyABKA4yGi5maW5hbmNpYWwuVHJhbnNhY3Rp",
            "b25UeXBlEiwKBlN0YXR1cxgEIAEoDjIcLmZpbmFuY2lhbC5UcmFuc2FjdGlv",
            "blN0YXR1cxIVCg1UcmFuc2FjdGlvbklEGAUgASgJEhcKD1RyYW5zYWN0aW9u",
            "RGF0ZRgGIAEoAyo6Cg9UcmFuc2FjdGlvblR5cGUSCwoHREVQT1NJVBAAEg4K",
            "CldJVEhEUkFXQUwQARIKCgZSRUZVTkQQAipdChFUcmFuc2FjdGlvblN0YXR1",
            "cxINCglJTklUSUFURUQQABIPCgtJTl9QUk9HUkVTUxABEg0KCUNBTkNFTExF",
            "RBACEg0KCUNPTVBMRVRFRBADEgoKBkZBSUxFRBAEMs4BChRGaW5hbmNpYWxU",
            "cmFuc2FjdGlvbhJVChJQcm9jZXNzVHJhbnNhY3Rpb24SHS5maW5hbmNpYWwu",
            "VHJhbnNhY3Rpb25SZXF1ZXN0Gh4uZmluYW5jaWFsLlRyYW5zYWN0aW9uUmVz",
            "cG9uc2UiABJfChhQcm9jZXNzVHJhbnNhY3Rpb25TdHJlYW0SHS5maW5hbmNp",
            "YWwuVHJhbnNhY3Rpb25SZXF1ZXN0Gh4uZmluYW5jaWFsLlRyYW5zYWN0aW9u",
            "UmVzcG9uc2UiACgBMAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Financial.TransactionType), typeof(global::Financial.TransactionStatus), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Financial.TransactionRequest), global::Financial.TransactionRequest.Parser, new[]{ "AccountID", "Amount", "Type", "Status" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Financial.TransactionResponse), global::Financial.TransactionResponse.Parser, new[]{ "AccountID", "Amount", "Type", "Status", "TransactionID", "TransactionDate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum TransactionType {
    [pbr::OriginalName("DEPOSIT")] Deposit = 0,
    [pbr::OriginalName("WITHDRAWAL")] Withdrawal = 1,
    [pbr::OriginalName("REFUND")] Refund = 2,
  }

  public enum TransactionStatus {
    [pbr::OriginalName("INITIATED")] Initiated = 0,
    [pbr::OriginalName("IN_PROGRESS")] InProgress = 1,
    [pbr::OriginalName("CANCELLED")] Cancelled = 2,
    [pbr::OriginalName("COMPLETED")] Completed = 3,
    [pbr::OriginalName("FAILED")] Failed = 4,
  }

  #endregion

  #region Messages
  public sealed partial class TransactionRequest : pb::IMessage<TransactionRequest> {
    private static readonly pb::MessageParser<TransactionRequest> _parser = new pb::MessageParser<TransactionRequest>(() => new TransactionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TransactionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Financial.FinanceRPCReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionRequest(TransactionRequest other) : this() {
      accountID_ = other.accountID_;
      amount_ = other.amount_;
      type_ = other.type_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionRequest Clone() {
      return new TransactionRequest(this);
    }

    /// <summary>Field number for the "AccountID" field.</summary>
    public const int AccountIDFieldNumber = 1;
    private string accountID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AccountID {
      get { return accountID_; }
      set {
        accountID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private double amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "Type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Financial.TransactionType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Financial.TransactionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "Status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Financial.TransactionStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Financial.TransactionStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TransactionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TransactionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountID != other.AccountID) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Amount, other.Amount)) return false;
      if (Type != other.Type) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AccountID.Length != 0) hash ^= AccountID.GetHashCode();
      if (Amount != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Amount);
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AccountID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AccountID);
      }
      if (Amount != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Amount);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Status != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AccountID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccountID);
      }
      if (Amount != 0D) {
        size += 1 + 8;
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TransactionRequest other) {
      if (other == null) {
        return;
      }
      if (other.AccountID.Length != 0) {
        AccountID = other.AccountID;
      }
      if (other.Amount != 0D) {
        Amount = other.Amount;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AccountID = input.ReadString();
            break;
          }
          case 17: {
            Amount = input.ReadDouble();
            break;
          }
          case 24: {
            type_ = (global::Financial.TransactionType) input.ReadEnum();
            break;
          }
          case 32: {
            status_ = (global::Financial.TransactionStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TransactionResponse : pb::IMessage<TransactionResponse> {
    private static readonly pb::MessageParser<TransactionResponse> _parser = new pb::MessageParser<TransactionResponse>(() => new TransactionResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TransactionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Financial.FinanceRPCReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionResponse(TransactionResponse other) : this() {
      accountID_ = other.accountID_;
      amount_ = other.amount_;
      type_ = other.type_;
      status_ = other.status_;
      transactionID_ = other.transactionID_;
      transactionDate_ = other.transactionDate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionResponse Clone() {
      return new TransactionResponse(this);
    }

    /// <summary>Field number for the "AccountID" field.</summary>
    public const int AccountIDFieldNumber = 1;
    private string accountID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AccountID {
      get { return accountID_; }
      set {
        accountID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private double amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "Type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Financial.TransactionType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Financial.TransactionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "Status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Financial.TransactionStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Financial.TransactionStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "TransactionID" field.</summary>
    public const int TransactionIDFieldNumber = 5;
    private string transactionID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TransactionID {
      get { return transactionID_; }
      set {
        transactionID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "TransactionDate" field.</summary>
    public const int TransactionDateFieldNumber = 6;
    private long transactionDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TransactionDate {
      get { return transactionDate_; }
      set {
        transactionDate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TransactionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TransactionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountID != other.AccountID) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Amount, other.Amount)) return false;
      if (Type != other.Type) return false;
      if (Status != other.Status) return false;
      if (TransactionID != other.TransactionID) return false;
      if (TransactionDate != other.TransactionDate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AccountID.Length != 0) hash ^= AccountID.GetHashCode();
      if (Amount != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Amount);
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (TransactionID.Length != 0) hash ^= TransactionID.GetHashCode();
      if (TransactionDate != 0L) hash ^= TransactionDate.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AccountID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AccountID);
      }
      if (Amount != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Amount);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Status != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (TransactionID.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(TransactionID);
      }
      if (TransactionDate != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(TransactionDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AccountID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccountID);
      }
      if (Amount != 0D) {
        size += 1 + 8;
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (TransactionID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TransactionID);
      }
      if (TransactionDate != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TransactionDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TransactionResponse other) {
      if (other == null) {
        return;
      }
      if (other.AccountID.Length != 0) {
        AccountID = other.AccountID;
      }
      if (other.Amount != 0D) {
        Amount = other.Amount;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.TransactionID.Length != 0) {
        TransactionID = other.TransactionID;
      }
      if (other.TransactionDate != 0L) {
        TransactionDate = other.TransactionDate;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AccountID = input.ReadString();
            break;
          }
          case 17: {
            Amount = input.ReadDouble();
            break;
          }
          case 24: {
            type_ = (global::Financial.TransactionType) input.ReadEnum();
            break;
          }
          case 32: {
            status_ = (global::Financial.TransactionStatus) input.ReadEnum();
            break;
          }
          case 42: {
            TransactionID = input.ReadString();
            break;
          }
          case 48: {
            TransactionDate = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
