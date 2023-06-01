// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MiaoCsharp
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct GuestTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static GuestTable GetRootAsGuestTable(ByteBuffer _bb) { return GetRootAsGuestTable(_bb, new GuestTable()); }
  public static GuestTable GetRootAsGuestTable(ByteBuffer _bb, GuestTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GuestTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public MiaoCsharp.GuestData? Datas(int j) { int o = __p.__offset(4); return o != 0 ? (MiaoCsharp.GuestData?)(new MiaoCsharp.GuestData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DatasLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<MiaoCsharp.GuestTable> CreateGuestTable(FlatBufferBuilder builder,
      VectorOffset datasOffset = default(VectorOffset)) {
    builder.StartTable(1);
    GuestTable.AddDatas(builder, datasOffset);
    return GuestTable.EndGuestTable(builder);
  }

  public static void StartGuestTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDatas(FlatBufferBuilder builder, VectorOffset datasOffset) { builder.AddOffset(0, datasOffset.Value, 0); }
  public static VectorOffset CreateDatasVector(FlatBufferBuilder builder, Offset<MiaoCsharp.GuestData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDatasVectorBlock(FlatBufferBuilder builder, Offset<MiaoCsharp.GuestData>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDatasVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<MiaoCsharp.GuestTable> EndGuestTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<MiaoCsharp.GuestTable>(o);
  }
  public static void FinishGuestTableBuffer(FlatBufferBuilder builder, Offset<MiaoCsharp.GuestTable> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedGuestTableBuffer(FlatBufferBuilder builder, Offset<MiaoCsharp.GuestTable> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}
