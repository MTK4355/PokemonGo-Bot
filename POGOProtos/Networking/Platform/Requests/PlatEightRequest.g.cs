// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Platform/Requests/PlatEightRequest.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform.Requests {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Platform/Requests/PlatEightRequest.proto</summary>
  public static partial class PlatEightRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Platform/Requests/PlatEightRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlatEightRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUGxhdGZvcm0vUmVxdWVzdHMvUGxh",
            "dEVpZ2h0UmVxdWVzdC5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlBs",
            "YXRmb3JtLlJlcXVlc3RzIiIKEFBsYXRFaWdodFJlcXVlc3QSDgoGZmllbGQx",
            "GAEgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Requests.PlatEightRequest), global::POGOProtos.Networking.Platform.Requests.PlatEightRequest.Parser, new[]{ "Field1" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlatEightRequest : pb::IMessage<PlatEightRequest> {
    private static readonly pb::MessageParser<PlatEightRequest> _parser = new pb::MessageParser<PlatEightRequest>(() => new PlatEightRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlatEightRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Requests.PlatEightRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlatEightRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlatEightRequest(PlatEightRequest other) : this() {
      field1_ = other.field1_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlatEightRequest Clone() {
      return new PlatEightRequest(this);
    }

    /// <summary>Field number for the "field1" field.</summary>
    public const int Field1FieldNumber = 1;
    private string field1_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Field1 {
      get { return field1_; }
      set {
        field1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlatEightRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlatEightRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Field1 != other.Field1) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Field1.Length != 0) hash ^= Field1.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Field1.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Field1);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Field1.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Field1);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlatEightRequest other) {
      if (other == null) {
        return;
      }
      if (other.Field1.Length != 0) {
        Field1 = other.Field1;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Field1 = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code