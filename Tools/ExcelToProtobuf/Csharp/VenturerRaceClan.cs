// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Venturer_RaceClan.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Deploy {

  /// <summary>Holder for reflection information generated from Venturer_RaceClan.proto</summary>
  public static partial class VenturerRaceClanReflection {

    #region Descriptor
    /// <summary>File descriptor for Venturer_RaceClan.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VenturerRaceClanReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdWZW50dXJlcl9SYWNlQ2xhbi5wcm90bxIGZGVwbG95IsAJChFWZW50dXJl",
            "cl9SYWNlQ2xhbhIKCgJJZBgBIAEoBRIMCgROYW1lGAIgASgJEg0KBUNsYXNz",
            "GAMgASgFEg8KB1ZhcmlldHkYBCABKAUSDAoERGVzYxgFIAEoCRISCgpQcmVm",
            "YWJOYW1lGAYgASgJEkcKD1NraW5QYXJ0U2xvdE1hcBgHIAMoCzIuLmRlcGxv",
            "eS5WZW50dXJlcl9SYWNlQ2xhbi5Ta2luUGFydFNsb3RNYXBFbnRyeRJLChFT",
            "a2luQ29sb3JIU1ZSYW5nZRgIIAMoCzIwLmRlcGxveS5WZW50dXJlcl9SYWNl",
            "Q2xhbi5Ta2luQ29sb3JIU1ZSYW5nZUVudHJ5EhMKC1NwYXduV2VpZ2h0GAkg",
            "ASgFEhUKDUxpZmVUdXJuUmFuZ2UYCiADKAUSQQoMR2VuZGVyV2VpZ2h0GAsg",
            "AygLMisuZGVwbG95LlZlbnR1cmVyX1JhY2VDbGFuLkdlbmRlcldlaWdodEVu",
            "dHJ5EkcKD0FsaWdubWVudFdlaWdodBgMIAMoCzIuLmRlcGxveS5WZW50dXJl",
            "cl9SYWNlQ2xhbi5BbGlnbm1lbnRXZWlnaHRFbnRyeRJHCg9HaWZ0Q291bnRX",
            "ZWlnaHQYDSADKAsyLi5kZXBsb3kuVmVudHVyZXJfUmFjZUNsYW4uR2lmdENv",
            "dW50V2VpZ2h0RW50cnkSPQoKR2lmdFdlaWdodBgOIAMoCzIpLmRlcGxveS5W",
            "ZW50dXJlcl9SYWNlQ2xhbi5HaWZ0V2VpZ2h0RW50cnkSOwoJQXR0ckFtZW5k",
            "GA8gAygLMiguZGVwbG95LlZlbnR1cmVyX1JhY2VDbGFuLkF0dHJBbWVuZEVu",
            "dHJ5EhQKDE5hbWVTb3J0VHlwZRgQIAEoBRIXCg9TdXJuYW1lR3JvdXBJZHMY",
            "ESADKAUSQQoMTmFtZUdyb3VwSWRzGBIgAygLMisuZGVwbG95LlZlbnR1cmVy",
            "X1JhY2VDbGFuLk5hbWVHcm91cElkc0VudHJ5EhkKEUV4dHJhbmFtZUdyb3Vw",
            "SWRzGBMgAygFGjYKFFNraW5QYXJ0U2xvdE1hcEVudHJ5EgsKA2tleRgBIAEo",
            "BRINCgV2YWx1ZRgCIAEoCToCOAEaOAoWU2tpbkNvbG9ySFNWUmFuZ2VFbnRy",
            "eRILCgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAk6AjgBGjMKEUdlbmRlcldl",
            "aWdodEVudHJ5EgsKA2tleRgBIAEoBRINCgV2YWx1ZRgCIAEoBToCOAEaNgoU",
            "QWxpZ25tZW50V2VpZ2h0RW50cnkSCwoDa2V5GAEgASgFEg0KBXZhbHVlGAIg",
            "ASgFOgI4ARo2ChRHaWZ0Q291bnRXZWlnaHRFbnRyeRILCgNrZXkYASABKAUS",
            "DQoFdmFsdWUYAiABKAU6AjgBGjEKD0dpZnRXZWlnaHRFbnRyeRILCgNrZXkY",
            "ASABKAUSDQoFdmFsdWUYAiABKAU6AjgBGjAKDkF0dHJBbWVuZEVudHJ5EgsK",
            "A2tleRgBIAEoBRINCgV2YWx1ZRgCIAEoBToCOAEaMwoRTmFtZUdyb3VwSWRz",
            "RW50cnkSCwoDa2V5GAEgASgFEg0KBXZhbHVlGAIgASgJOgI4ASKZAQoVVmVu",
            "dHVyZXJfUmFjZUNsYW5fTWFwEjcKBUl0ZW1zGAEgAygLMiguZGVwbG95LlZl",
            "bnR1cmVyX1JhY2VDbGFuX01hcC5JdGVtc0VudHJ5GkcKCkl0ZW1zRW50cnkS",
            "CwoDa2V5GAEgASgFEigKBXZhbHVlGAIgASgLMhkuZGVwbG95LlZlbnR1cmVy",
            "X1JhY2VDbGFuOgI4AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Deploy.Venturer_RaceClan), global::Deploy.Venturer_RaceClan.Parser, new[]{ "Id", "Name", "Class", "Variety", "Desc", "PrefabName", "SkinPartSlotMap", "SkinColorHSVRange", "SpawnWeight", "LifeTurnRange", "GenderWeight", "AlignmentWeight", "GiftCountWeight", "GiftWeight", "AttrAmend", "NameSortType", "SurnameGroupIds", "NameGroupIds", "ExtranameGroupIds" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, null, null, null, null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Deploy.Venturer_RaceClan_Map), global::Deploy.Venturer_RaceClan_Map.Parser, new[]{ "Items" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Venturer_RaceClan : pb::IMessage<Venturer_RaceClan> {
    private static readonly pb::MessageParser<Venturer_RaceClan> _parser = new pb::MessageParser<Venturer_RaceClan>(() => new Venturer_RaceClan());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Venturer_RaceClan> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Deploy.VenturerRaceClanReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venturer_RaceClan() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venturer_RaceClan(Venturer_RaceClan other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      class_ = other.class_;
      variety_ = other.variety_;
      desc_ = other.desc_;
      prefabName_ = other.prefabName_;
      skinPartSlotMap_ = other.skinPartSlotMap_.Clone();
      skinColorHSVRange_ = other.skinColorHSVRange_.Clone();
      spawnWeight_ = other.spawnWeight_;
      lifeTurnRange_ = other.lifeTurnRange_.Clone();
      genderWeight_ = other.genderWeight_.Clone();
      alignmentWeight_ = other.alignmentWeight_.Clone();
      giftCountWeight_ = other.giftCountWeight_.Clone();
      giftWeight_ = other.giftWeight_.Clone();
      attrAmend_ = other.attrAmend_.Clone();
      nameSortType_ = other.nameSortType_;
      surnameGroupIds_ = other.surnameGroupIds_.Clone();
      nameGroupIds_ = other.nameGroupIds_.Clone();
      extranameGroupIds_ = other.extranameGroupIds_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venturer_RaceClan Clone() {
      return new Venturer_RaceClan(this);
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

    /// <summary>Field number for the "Class" field.</summary>
    public const int ClassFieldNumber = 3;
    private int class_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Class {
      get { return class_; }
      set {
        class_ = value;
      }
    }

    /// <summary>Field number for the "Variety" field.</summary>
    public const int VarietyFieldNumber = 4;
    private int variety_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Variety {
      get { return variety_; }
      set {
        variety_ = value;
      }
    }

    /// <summary>Field number for the "Desc" field.</summary>
    public const int DescFieldNumber = 5;
    private string desc_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Desc {
      get { return desc_; }
      set {
        desc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PrefabName" field.</summary>
    public const int PrefabNameFieldNumber = 6;
    private string prefabName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PrefabName {
      get { return prefabName_; }
      set {
        prefabName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "SkinPartSlotMap" field.</summary>
    public const int SkinPartSlotMapFieldNumber = 7;
    private static readonly pbc::MapField<int, string>.Codec _map_skinPartSlotMap_codec
        = new pbc::MapField<int, string>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForString(18, ""), 58);
    private readonly pbc::MapField<int, string> skinPartSlotMap_ = new pbc::MapField<int, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, string> SkinPartSlotMap {
      get { return skinPartSlotMap_; }
    }

    /// <summary>Field number for the "SkinColorHSVRange" field.</summary>
    public const int SkinColorHSVRangeFieldNumber = 8;
    private static readonly pbc::MapField<int, string>.Codec _map_skinColorHSVRange_codec
        = new pbc::MapField<int, string>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForString(18, ""), 66);
    private readonly pbc::MapField<int, string> skinColorHSVRange_ = new pbc::MapField<int, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, string> SkinColorHSVRange {
      get { return skinColorHSVRange_; }
    }

    /// <summary>Field number for the "SpawnWeight" field.</summary>
    public const int SpawnWeightFieldNumber = 9;
    private int spawnWeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SpawnWeight {
      get { return spawnWeight_; }
      set {
        spawnWeight_ = value;
      }
    }

    /// <summary>Field number for the "LifeTurnRange" field.</summary>
    public const int LifeTurnRangeFieldNumber = 10;
    private static readonly pb::FieldCodec<int> _repeated_lifeTurnRange_codec
        = pb::FieldCodec.ForInt32(82);
    private readonly pbc::RepeatedField<int> lifeTurnRange_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> LifeTurnRange {
      get { return lifeTurnRange_; }
    }

    /// <summary>Field number for the "GenderWeight" field.</summary>
    public const int GenderWeightFieldNumber = 11;
    private static readonly pbc::MapField<int, int>.Codec _map_genderWeight_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 90);
    private readonly pbc::MapField<int, int> genderWeight_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> GenderWeight {
      get { return genderWeight_; }
    }

    /// <summary>Field number for the "AlignmentWeight" field.</summary>
    public const int AlignmentWeightFieldNumber = 12;
    private static readonly pbc::MapField<int, int>.Codec _map_alignmentWeight_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 98);
    private readonly pbc::MapField<int, int> alignmentWeight_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> AlignmentWeight {
      get { return alignmentWeight_; }
    }

    /// <summary>Field number for the "GiftCountWeight" field.</summary>
    public const int GiftCountWeightFieldNumber = 13;
    private static readonly pbc::MapField<int, int>.Codec _map_giftCountWeight_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 106);
    private readonly pbc::MapField<int, int> giftCountWeight_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> GiftCountWeight {
      get { return giftCountWeight_; }
    }

    /// <summary>Field number for the "GiftWeight" field.</summary>
    public const int GiftWeightFieldNumber = 14;
    private static readonly pbc::MapField<int, int>.Codec _map_giftWeight_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 114);
    private readonly pbc::MapField<int, int> giftWeight_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> GiftWeight {
      get { return giftWeight_; }
    }

    /// <summary>Field number for the "AttrAmend" field.</summary>
    public const int AttrAmendFieldNumber = 15;
    private static readonly pbc::MapField<int, int>.Codec _map_attrAmend_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 122);
    private readonly pbc::MapField<int, int> attrAmend_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> AttrAmend {
      get { return attrAmend_; }
    }

    /// <summary>Field number for the "NameSortType" field.</summary>
    public const int NameSortTypeFieldNumber = 16;
    private int nameSortType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NameSortType {
      get { return nameSortType_; }
      set {
        nameSortType_ = value;
      }
    }

    /// <summary>Field number for the "SurnameGroupIds" field.</summary>
    public const int SurnameGroupIdsFieldNumber = 17;
    private static readonly pb::FieldCodec<int> _repeated_surnameGroupIds_codec
        = pb::FieldCodec.ForInt32(138);
    private readonly pbc::RepeatedField<int> surnameGroupIds_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> SurnameGroupIds {
      get { return surnameGroupIds_; }
    }

    /// <summary>Field number for the "NameGroupIds" field.</summary>
    public const int NameGroupIdsFieldNumber = 18;
    private static readonly pbc::MapField<int, string>.Codec _map_nameGroupIds_codec
        = new pbc::MapField<int, string>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForString(18, ""), 146);
    private readonly pbc::MapField<int, string> nameGroupIds_ = new pbc::MapField<int, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, string> NameGroupIds {
      get { return nameGroupIds_; }
    }

    /// <summary>Field number for the "ExtranameGroupIds" field.</summary>
    public const int ExtranameGroupIdsFieldNumber = 19;
    private static readonly pb::FieldCodec<int> _repeated_extranameGroupIds_codec
        = pb::FieldCodec.ForInt32(154);
    private readonly pbc::RepeatedField<int> extranameGroupIds_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> ExtranameGroupIds {
      get { return extranameGroupIds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Venturer_RaceClan);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Venturer_RaceClan other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Class != other.Class) return false;
      if (Variety != other.Variety) return false;
      if (Desc != other.Desc) return false;
      if (PrefabName != other.PrefabName) return false;
      if (!SkinPartSlotMap.Equals(other.SkinPartSlotMap)) return false;
      if (!SkinColorHSVRange.Equals(other.SkinColorHSVRange)) return false;
      if (SpawnWeight != other.SpawnWeight) return false;
      if(!lifeTurnRange_.Equals(other.lifeTurnRange_)) return false;
      if (!GenderWeight.Equals(other.GenderWeight)) return false;
      if (!AlignmentWeight.Equals(other.AlignmentWeight)) return false;
      if (!GiftCountWeight.Equals(other.GiftCountWeight)) return false;
      if (!GiftWeight.Equals(other.GiftWeight)) return false;
      if (!AttrAmend.Equals(other.AttrAmend)) return false;
      if (NameSortType != other.NameSortType) return false;
      if(!surnameGroupIds_.Equals(other.surnameGroupIds_)) return false;
      if (!NameGroupIds.Equals(other.NameGroupIds)) return false;
      if(!extranameGroupIds_.Equals(other.extranameGroupIds_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Class != 0) hash ^= Class.GetHashCode();
      if (Variety != 0) hash ^= Variety.GetHashCode();
      if (Desc.Length != 0) hash ^= Desc.GetHashCode();
      if (PrefabName.Length != 0) hash ^= PrefabName.GetHashCode();
      hash ^= SkinPartSlotMap.GetHashCode();
      hash ^= SkinColorHSVRange.GetHashCode();
      if (SpawnWeight != 0) hash ^= SpawnWeight.GetHashCode();
      hash ^= lifeTurnRange_.GetHashCode();
      hash ^= GenderWeight.GetHashCode();
      hash ^= AlignmentWeight.GetHashCode();
      hash ^= GiftCountWeight.GetHashCode();
      hash ^= GiftWeight.GetHashCode();
      hash ^= AttrAmend.GetHashCode();
      if (NameSortType != 0) hash ^= NameSortType.GetHashCode();
      hash ^= surnameGroupIds_.GetHashCode();
      hash ^= NameGroupIds.GetHashCode();
      hash ^= extranameGroupIds_.GetHashCode();
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
      if (Class != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Class);
      }
      if (Variety != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Variety);
      }
      if (Desc.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Desc);
      }
      if (PrefabName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PrefabName);
      }
      skinPartSlotMap_.WriteTo(output, _map_skinPartSlotMap_codec);
      skinColorHSVRange_.WriteTo(output, _map_skinColorHSVRange_codec);
      if (SpawnWeight != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(SpawnWeight);
      }
      lifeTurnRange_.WriteTo(output, _repeated_lifeTurnRange_codec);
      genderWeight_.WriteTo(output, _map_genderWeight_codec);
      alignmentWeight_.WriteTo(output, _map_alignmentWeight_codec);
      giftCountWeight_.WriteTo(output, _map_giftCountWeight_codec);
      giftWeight_.WriteTo(output, _map_giftWeight_codec);
      attrAmend_.WriteTo(output, _map_attrAmend_codec);
      if (NameSortType != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(NameSortType);
      }
      surnameGroupIds_.WriteTo(output, _repeated_surnameGroupIds_codec);
      nameGroupIds_.WriteTo(output, _map_nameGroupIds_codec);
      extranameGroupIds_.WriteTo(output, _repeated_extranameGroupIds_codec);
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
      if (Class != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Class);
      }
      if (Variety != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Variety);
      }
      if (Desc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Desc);
      }
      if (PrefabName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PrefabName);
      }
      size += skinPartSlotMap_.CalculateSize(_map_skinPartSlotMap_codec);
      size += skinColorHSVRange_.CalculateSize(_map_skinColorHSVRange_codec);
      if (SpawnWeight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SpawnWeight);
      }
      size += lifeTurnRange_.CalculateSize(_repeated_lifeTurnRange_codec);
      size += genderWeight_.CalculateSize(_map_genderWeight_codec);
      size += alignmentWeight_.CalculateSize(_map_alignmentWeight_codec);
      size += giftCountWeight_.CalculateSize(_map_giftCountWeight_codec);
      size += giftWeight_.CalculateSize(_map_giftWeight_codec);
      size += attrAmend_.CalculateSize(_map_attrAmend_codec);
      if (NameSortType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(NameSortType);
      }
      size += surnameGroupIds_.CalculateSize(_repeated_surnameGroupIds_codec);
      size += nameGroupIds_.CalculateSize(_map_nameGroupIds_codec);
      size += extranameGroupIds_.CalculateSize(_repeated_extranameGroupIds_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Venturer_RaceClan other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Class != 0) {
        Class = other.Class;
      }
      if (other.Variety != 0) {
        Variety = other.Variety;
      }
      if (other.Desc.Length != 0) {
        Desc = other.Desc;
      }
      if (other.PrefabName.Length != 0) {
        PrefabName = other.PrefabName;
      }
      skinPartSlotMap_.Add(other.skinPartSlotMap_);
      skinColorHSVRange_.Add(other.skinColorHSVRange_);
      if (other.SpawnWeight != 0) {
        SpawnWeight = other.SpawnWeight;
      }
      lifeTurnRange_.Add(other.lifeTurnRange_);
      genderWeight_.Add(other.genderWeight_);
      alignmentWeight_.Add(other.alignmentWeight_);
      giftCountWeight_.Add(other.giftCountWeight_);
      giftWeight_.Add(other.giftWeight_);
      attrAmend_.Add(other.attrAmend_);
      if (other.NameSortType != 0) {
        NameSortType = other.NameSortType;
      }
      surnameGroupIds_.Add(other.surnameGroupIds_);
      nameGroupIds_.Add(other.nameGroupIds_);
      extranameGroupIds_.Add(other.extranameGroupIds_);
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
          case 24: {
            Class = input.ReadInt32();
            break;
          }
          case 32: {
            Variety = input.ReadInt32();
            break;
          }
          case 42: {
            Desc = input.ReadString();
            break;
          }
          case 50: {
            PrefabName = input.ReadString();
            break;
          }
          case 58: {
            skinPartSlotMap_.AddEntriesFrom(input, _map_skinPartSlotMap_codec);
            break;
          }
          case 66: {
            skinColorHSVRange_.AddEntriesFrom(input, _map_skinColorHSVRange_codec);
            break;
          }
          case 72: {
            SpawnWeight = input.ReadInt32();
            break;
          }
          case 82:
          case 80: {
            lifeTurnRange_.AddEntriesFrom(input, _repeated_lifeTurnRange_codec);
            break;
          }
          case 90: {
            genderWeight_.AddEntriesFrom(input, _map_genderWeight_codec);
            break;
          }
          case 98: {
            alignmentWeight_.AddEntriesFrom(input, _map_alignmentWeight_codec);
            break;
          }
          case 106: {
            giftCountWeight_.AddEntriesFrom(input, _map_giftCountWeight_codec);
            break;
          }
          case 114: {
            giftWeight_.AddEntriesFrom(input, _map_giftWeight_codec);
            break;
          }
          case 122: {
            attrAmend_.AddEntriesFrom(input, _map_attrAmend_codec);
            break;
          }
          case 128: {
            NameSortType = input.ReadInt32();
            break;
          }
          case 138:
          case 136: {
            surnameGroupIds_.AddEntriesFrom(input, _repeated_surnameGroupIds_codec);
            break;
          }
          case 146: {
            nameGroupIds_.AddEntriesFrom(input, _map_nameGroupIds_codec);
            break;
          }
          case 154:
          case 152: {
            extranameGroupIds_.AddEntriesFrom(input, _repeated_extranameGroupIds_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Venturer_RaceClan_Map : pb::IMessage<Venturer_RaceClan_Map> {
    private static readonly pb::MessageParser<Venturer_RaceClan_Map> _parser = new pb::MessageParser<Venturer_RaceClan_Map>(() => new Venturer_RaceClan_Map());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Venturer_RaceClan_Map> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Deploy.VenturerRaceClanReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venturer_RaceClan_Map() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venturer_RaceClan_Map(Venturer_RaceClan_Map other) : this() {
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venturer_RaceClan_Map Clone() {
      return new Venturer_RaceClan_Map(this);
    }

    /// <summary>Field number for the "Items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pbc::MapField<int, global::Deploy.Venturer_RaceClan>.Codec _map_items_codec
        = new pbc::MapField<int, global::Deploy.Venturer_RaceClan>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Deploy.Venturer_RaceClan.Parser), 10);
    private readonly pbc::MapField<int, global::Deploy.Venturer_RaceClan> items_ = new pbc::MapField<int, global::Deploy.Venturer_RaceClan>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Deploy.Venturer_RaceClan> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Venturer_RaceClan_Map);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Venturer_RaceClan_Map other) {
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
    public void MergeFrom(Venturer_RaceClan_Map other) {
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
