// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Profession_Config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Deploy {

  /// <summary>Holder for reflection information generated from Profession_Config.proto</summary>
  public static partial class ProfessionConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for Profession_Config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfessionConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm9mZXNzaW9uX0NvbmZpZy5wcm90bxIGZGVwbG95IvEDChFQcm9mZXNz",
            "aW9uX0NvbmZpZxIKCgJJZBgBIAEoBRIPCgdGYWN0aW9uGAIgASgFEgwKBE5h",
            "bWUYAyABKAkSDAoESWNvbhgEIAEoCRIeChZCYXNlZFByb2Zlc3Npb25JZEFy",
            "cmF5GAUgAygFEgwKBERlc2MYBiABKAkSOwoJQXR0ckJvbnVzGAcgAygLMigu",
            "ZGVwbG95LlByb2Zlc3Npb25fQ29uZmlnLkF0dHJCb251c0VudHJ5EkMKDUNv",
            "bmRpdGlvblJhbmsYCCADKAsyLC5kZXBsb3kuUHJvZmVzc2lvbl9Db25maWcu",
            "Q29uZGl0aW9uUmFua0VudHJ5Ek8KE0NvbmRpdGlvblByb3BvcnRpb24YCSAD",
            "KAsyMi5kZXBsb3kuUHJvZmVzc2lvbl9Db25maWcuQ29uZGl0aW9uUHJvcG9y",
            "dGlvbkVudHJ5GjAKDkF0dHJCb251c0VudHJ5EgsKA2tleRgBIAEoBRINCgV2",
            "YWx1ZRgCIAEoBToCOAEaNAoSQ29uZGl0aW9uUmFua0VudHJ5EgsKA2tleRgB",
            "IAEoBRINCgV2YWx1ZRgCIAEoBToCOAEaOgoYQ29uZGl0aW9uUHJvcG9ydGlv",
            "bkVudHJ5EgsKA2tleRgBIAEoBRINCgV2YWx1ZRgCIAEoBToCOAEimQEKFVBy",
            "b2Zlc3Npb25fQ29uZmlnX01hcBI3CgVJdGVtcxgBIAMoCzIoLmRlcGxveS5Q",
            "cm9mZXNzaW9uX0NvbmZpZ19NYXAuSXRlbXNFbnRyeRpHCgpJdGVtc0VudHJ5",
            "EgsKA2tleRgBIAEoBRIoCgV2YWx1ZRgCIAEoCzIZLmRlcGxveS5Qcm9mZXNz",
            "aW9uX0NvbmZpZzoCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Deploy.Profession_Config), global::Deploy.Profession_Config.Parser, new[]{ "Id", "Faction", "Name", "Icon", "BasedProfessionIdArray", "Desc", "AttrBonus", "ConditionRank", "ConditionProportion" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Deploy.Profession_Config_Map), global::Deploy.Profession_Config_Map.Parser, new[]{ "Items" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Profession_Config : pb::IMessage<Profession_Config> {
    private static readonly pb::MessageParser<Profession_Config> _parser = new pb::MessageParser<Profession_Config>(() => new Profession_Config());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Profession_Config> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Deploy.ProfessionConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profession_Config() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profession_Config(Profession_Config other) : this() {
      id_ = other.id_;
      faction_ = other.faction_;
      name_ = other.name_;
      icon_ = other.icon_;
      basedProfessionIdArray_ = other.basedProfessionIdArray_.Clone();
      desc_ = other.desc_;
      attrBonus_ = other.attrBonus_.Clone();
      conditionRank_ = other.conditionRank_.Clone();
      conditionProportion_ = other.conditionProportion_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profession_Config Clone() {
      return new Profession_Config(this);
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

    /// <summary>Field number for the "Faction" field.</summary>
    public const int FactionFieldNumber = 2;
    private int faction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Faction {
      get { return faction_; }
      set {
        faction_ = value;
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Icon" field.</summary>
    public const int IconFieldNumber = 4;
    private string icon_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Icon {
      get { return icon_; }
      set {
        icon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "BasedProfessionIdArray" field.</summary>
    public const int BasedProfessionIdArrayFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_basedProfessionIdArray_codec
        = pb::FieldCodec.ForInt32(42);
    private readonly pbc::RepeatedField<int> basedProfessionIdArray_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> BasedProfessionIdArray {
      get { return basedProfessionIdArray_; }
    }

    /// <summary>Field number for the "Desc" field.</summary>
    public const int DescFieldNumber = 6;
    private string desc_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Desc {
      get { return desc_; }
      set {
        desc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "AttrBonus" field.</summary>
    public const int AttrBonusFieldNumber = 7;
    private static readonly pbc::MapField<int, int>.Codec _map_attrBonus_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 58);
    private readonly pbc::MapField<int, int> attrBonus_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> AttrBonus {
      get { return attrBonus_; }
    }

    /// <summary>Field number for the "ConditionRank" field.</summary>
    public const int ConditionRankFieldNumber = 8;
    private static readonly pbc::MapField<int, int>.Codec _map_conditionRank_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 66);
    private readonly pbc::MapField<int, int> conditionRank_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> ConditionRank {
      get { return conditionRank_; }
    }

    /// <summary>Field number for the "ConditionProportion" field.</summary>
    public const int ConditionProportionFieldNumber = 9;
    private static readonly pbc::MapField<int, int>.Codec _map_conditionProportion_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 74);
    private readonly pbc::MapField<int, int> conditionProportion_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> ConditionProportion {
      get { return conditionProportion_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Profession_Config);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Profession_Config other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Faction != other.Faction) return false;
      if (Name != other.Name) return false;
      if (Icon != other.Icon) return false;
      if(!basedProfessionIdArray_.Equals(other.basedProfessionIdArray_)) return false;
      if (Desc != other.Desc) return false;
      if (!AttrBonus.Equals(other.AttrBonus)) return false;
      if (!ConditionRank.Equals(other.ConditionRank)) return false;
      if (!ConditionProportion.Equals(other.ConditionProportion)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Faction != 0) hash ^= Faction.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Icon.Length != 0) hash ^= Icon.GetHashCode();
      hash ^= basedProfessionIdArray_.GetHashCode();
      if (Desc.Length != 0) hash ^= Desc.GetHashCode();
      hash ^= AttrBonus.GetHashCode();
      hash ^= ConditionRank.GetHashCode();
      hash ^= ConditionProportion.GetHashCode();
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
      if (Faction != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Faction);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Icon.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Icon);
      }
      basedProfessionIdArray_.WriteTo(output, _repeated_basedProfessionIdArray_codec);
      if (Desc.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Desc);
      }
      attrBonus_.WriteTo(output, _map_attrBonus_codec);
      conditionRank_.WriteTo(output, _map_conditionRank_codec);
      conditionProportion_.WriteTo(output, _map_conditionProportion_codec);
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
      if (Faction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Faction);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Icon.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Icon);
      }
      size += basedProfessionIdArray_.CalculateSize(_repeated_basedProfessionIdArray_codec);
      if (Desc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Desc);
      }
      size += attrBonus_.CalculateSize(_map_attrBonus_codec);
      size += conditionRank_.CalculateSize(_map_conditionRank_codec);
      size += conditionProportion_.CalculateSize(_map_conditionProportion_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Profession_Config other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Faction != 0) {
        Faction = other.Faction;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Icon.Length != 0) {
        Icon = other.Icon;
      }
      basedProfessionIdArray_.Add(other.basedProfessionIdArray_);
      if (other.Desc.Length != 0) {
        Desc = other.Desc;
      }
      attrBonus_.Add(other.attrBonus_);
      conditionRank_.Add(other.conditionRank_);
      conditionProportion_.Add(other.conditionProportion_);
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
          case 16: {
            Faction = input.ReadInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Icon = input.ReadString();
            break;
          }
          case 42:
          case 40: {
            basedProfessionIdArray_.AddEntriesFrom(input, _repeated_basedProfessionIdArray_codec);
            break;
          }
          case 50: {
            Desc = input.ReadString();
            break;
          }
          case 58: {
            attrBonus_.AddEntriesFrom(input, _map_attrBonus_codec);
            break;
          }
          case 66: {
            conditionRank_.AddEntriesFrom(input, _map_conditionRank_codec);
            break;
          }
          case 74: {
            conditionProportion_.AddEntriesFrom(input, _map_conditionProportion_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Profession_Config_Map : pb::IMessage<Profession_Config_Map> {
    private static readonly pb::MessageParser<Profession_Config_Map> _parser = new pb::MessageParser<Profession_Config_Map>(() => new Profession_Config_Map());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Profession_Config_Map> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Deploy.ProfessionConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profession_Config_Map() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profession_Config_Map(Profession_Config_Map other) : this() {
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Profession_Config_Map Clone() {
      return new Profession_Config_Map(this);
    }

    /// <summary>Field number for the "Items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pbc::MapField<int, global::Deploy.Profession_Config>.Codec _map_items_codec
        = new pbc::MapField<int, global::Deploy.Profession_Config>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Deploy.Profession_Config.Parser), 10);
    private readonly pbc::MapField<int, global::Deploy.Profession_Config> items_ = new pbc::MapField<int, global::Deploy.Profession_Config>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Deploy.Profession_Config> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Profession_Config_Map);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Profession_Config_Map other) {
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
    public void MergeFrom(Profession_Config_Map other) {
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
