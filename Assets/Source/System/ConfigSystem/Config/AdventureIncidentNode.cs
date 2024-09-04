// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Adventure_IncidentNode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Deploy {

  /// <summary>Holder for reflection information generated from Adventure_IncidentNode.proto</summary>
  public static partial class AdventureIncidentNodeReflection {

    #region Descriptor
    /// <summary>File descriptor for Adventure_IncidentNode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdventureIncidentNodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxBZHZlbnR1cmVfSW5jaWRlbnROb2RlLnByb3RvEgZkZXBsb3kiswEKFkFk",
            "dmVudHVyZV9JbmNpZGVudE5vZGUSCgoCSWQYASABKAUSDAoETmFtZRgCIAEo",
            "CRIQCghEZXNjcmliZRgDIAEoCRITCgtDaG9vc2VBcnJheRgEIAMoBRIYChBT",
            "Y29yZUNvbXBhcmVUeXBlGAUgASgFEhkKEUxlYXZpbmdTY29yZUxpbWl0GAYg",
            "ASgFEhAKCE5vZGVUeXBlGAcgASgFEhEKCVBvaW50VG9JZBgIIAEoBSKoAQoa",
            "QWR2ZW50dXJlX0luY2lkZW50Tm9kZV9NYXASPAoFSXRlbXMYASADKAsyLS5k",
            "ZXBsb3kuQWR2ZW50dXJlX0luY2lkZW50Tm9kZV9NYXAuSXRlbXNFbnRyeRpM",
            "CgpJdGVtc0VudHJ5EgsKA2tleRgBIAEoBRItCgV2YWx1ZRgCIAEoCzIeLmRl",
            "cGxveS5BZHZlbnR1cmVfSW5jaWRlbnROb2RlOgI4AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Deploy.Adventure_IncidentNode), global::Deploy.Adventure_IncidentNode.Parser, new[]{ "Id", "Name", "Describe", "ChooseArray", "ScoreCompareType", "LeavingScoreLimit", "NodeType", "PointToId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Deploy.Adventure_IncidentNode_Map), global::Deploy.Adventure_IncidentNode_Map.Parser, new[]{ "Items" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Adventure_IncidentNode : pb::IMessage<Adventure_IncidentNode> {
    private static readonly pb::MessageParser<Adventure_IncidentNode> _parser = new pb::MessageParser<Adventure_IncidentNode>(() => new Adventure_IncidentNode());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Adventure_IncidentNode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Deploy.AdventureIncidentNodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Adventure_IncidentNode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Adventure_IncidentNode(Adventure_IncidentNode other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      describe_ = other.describe_;
      chooseArray_ = other.chooseArray_.Clone();
      scoreCompareType_ = other.scoreCompareType_;
      leavingScoreLimit_ = other.leavingScoreLimit_;
      nodeType_ = other.nodeType_;
      pointToId_ = other.pointToId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Adventure_IncidentNode Clone() {
      return new Adventure_IncidentNode(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Describe" field.</summary>
    public const int DescribeFieldNumber = 3;
    private string describe_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Describe {
      get { return describe_; }
      set {
        describe_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ChooseArray" field.</summary>
    public const int ChooseArrayFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_chooseArray_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> chooseArray_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> ChooseArray {
      get { return chooseArray_; }
    }

    /// <summary>Field number for the "ScoreCompareType" field.</summary>
    public const int ScoreCompareTypeFieldNumber = 5;
    private int scoreCompareType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ScoreCompareType {
      get { return scoreCompareType_; }
      set {
        scoreCompareType_ = value;
      }
    }

    /// <summary>Field number for the "LeavingScoreLimit" field.</summary>
    public const int LeavingScoreLimitFieldNumber = 6;
    private int leavingScoreLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LeavingScoreLimit {
      get { return leavingScoreLimit_; }
      set {
        leavingScoreLimit_ = value;
      }
    }

    /// <summary>Field number for the "NodeType" field.</summary>
    public const int NodeTypeFieldNumber = 7;
    private int nodeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NodeType {
      get { return nodeType_; }
      set {
        nodeType_ = value;
      }
    }

    /// <summary>Field number for the "PointToId" field.</summary>
    public const int PointToIdFieldNumber = 8;
    private int pointToId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PointToId {
      get { return pointToId_; }
      set {
        pointToId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Adventure_IncidentNode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Adventure_IncidentNode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Describe != other.Describe) return false;
      if(!chooseArray_.Equals(other.chooseArray_)) return false;
      if (ScoreCompareType != other.ScoreCompareType) return false;
      if (LeavingScoreLimit != other.LeavingScoreLimit) return false;
      if (NodeType != other.NodeType) return false;
      if (PointToId != other.PointToId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Describe.Length != 0) hash ^= Describe.GetHashCode();
      hash ^= chooseArray_.GetHashCode();
      if (ScoreCompareType != 0) hash ^= ScoreCompareType.GetHashCode();
      if (LeavingScoreLimit != 0) hash ^= LeavingScoreLimit.GetHashCode();
      if (NodeType != 0) hash ^= NodeType.GetHashCode();
      if (PointToId != 0) hash ^= PointToId.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Describe.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Describe);
      }
      chooseArray_.WriteTo(output, _repeated_chooseArray_codec);
      if (ScoreCompareType != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(ScoreCompareType);
      }
      if (LeavingScoreLimit != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(LeavingScoreLimit);
      }
      if (NodeType != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(NodeType);
      }
      if (PointToId != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(PointToId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Describe.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Describe);
      }
      size += chooseArray_.CalculateSize(_repeated_chooseArray_codec);
      if (ScoreCompareType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ScoreCompareType);
      }
      if (LeavingScoreLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LeavingScoreLimit);
      }
      if (NodeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NodeType);
      }
      if (PointToId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PointToId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Adventure_IncidentNode other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Describe.Length != 0) {
        Describe = other.Describe;
      }
      chooseArray_.Add(other.chooseArray_);
      if (other.ScoreCompareType != 0) {
        ScoreCompareType = other.ScoreCompareType;
      }
      if (other.LeavingScoreLimit != 0) {
        LeavingScoreLimit = other.LeavingScoreLimit;
      }
      if (other.NodeType != 0) {
        NodeType = other.NodeType;
      }
      if (other.PointToId != 0) {
        PointToId = other.PointToId;
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
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Describe = input.ReadString();
            break;
          }
          case 34:
          case 32: {
            chooseArray_.AddEntriesFrom(input, _repeated_chooseArray_codec);
            break;
          }
          case 40: {
            ScoreCompareType = input.ReadInt32();
            break;
          }
          case 48: {
            LeavingScoreLimit = input.ReadInt32();
            break;
          }
          case 56: {
            NodeType = input.ReadInt32();
            break;
          }
          case 64: {
            PointToId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Adventure_IncidentNode_Map : pb::IMessage<Adventure_IncidentNode_Map> {
    private static readonly pb::MessageParser<Adventure_IncidentNode_Map> _parser = new pb::MessageParser<Adventure_IncidentNode_Map>(() => new Adventure_IncidentNode_Map());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Adventure_IncidentNode_Map> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Deploy.AdventureIncidentNodeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Adventure_IncidentNode_Map() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Adventure_IncidentNode_Map(Adventure_IncidentNode_Map other) : this() {
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Adventure_IncidentNode_Map Clone() {
      return new Adventure_IncidentNode_Map(this);
    }

    /// <summary>Field number for the "Items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pbc::MapField<int, global::Deploy.Adventure_IncidentNode>.Codec _map_items_codec
        = new pbc::MapField<int, global::Deploy.Adventure_IncidentNode>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Deploy.Adventure_IncidentNode.Parser), 10);
    private readonly pbc::MapField<int, global::Deploy.Adventure_IncidentNode> items_ = new pbc::MapField<int, global::Deploy.Adventure_IncidentNode>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Deploy.Adventure_IncidentNode> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Adventure_IncidentNode_Map);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Adventure_IncidentNode_Map other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Items.Equals(other.Items)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Items.GetHashCode();
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
      items_.WriteTo(output, _map_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += items_.CalculateSize(_map_items_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Adventure_IncidentNode_Map other) {
      if (other == null) {
        return;
      }
      items_.Add(other.items_);
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
            items_.AddEntriesFrom(input, _map_items_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
