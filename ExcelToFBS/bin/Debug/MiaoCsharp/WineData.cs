// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MiaoCsharp
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct WineData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static WineData GetRootAsWineData(ByteBuffer _bb) { return GetRootAsWineData(_bb, new WineData()); }
  public static WineData GetRootAsWineData(ByteBuffer _bb, WineData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WineData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string Description { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(8); }
  public int SourceItem(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int SourceItemLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetSourceItemBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetSourceItemBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetSourceItemArray() { return __p.__vector_as_array<int>(10); }
  public string Icon { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(12); }
  public int Cost { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DishType { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<MiaoCsharp.WineData> CreateWineData(FlatBufferBuilder builder,
      int id = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset descriptionOffset = default(StringOffset),
      VectorOffset sourceItemOffset = default(VectorOffset),
      StringOffset iconOffset = default(StringOffset),
      int cost = 0,
      int dishType = 0) {
    builder.StartTable(7);
    WineData.AddDishType(builder, dishType);
    WineData.AddCost(builder, cost);
    WineData.AddIcon(builder, iconOffset);
    WineData.AddSourceItem(builder, sourceItemOffset);
    WineData.AddDescription(builder, descriptionOffset);
    WineData.AddName(builder, nameOffset);
    WineData.AddId(builder, id);
    return WineData.EndWineData(builder);
  }

  public static void StartWineData(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset) { builder.AddOffset(2, descriptionOffset.Value, 0); }
  public static void AddSourceItem(FlatBufferBuilder builder, VectorOffset sourceItemOffset) { builder.AddOffset(3, sourceItemOffset.Value, 0); }
  public static VectorOffset CreateSourceItemVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSourceItemVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartSourceItemVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(4, iconOffset.Value, 0); }
  public static void AddCost(FlatBufferBuilder builder, int cost) { builder.AddInt(5, cost, 0); }
  public static void AddDishType(FlatBufferBuilder builder, int dishType) { builder.AddInt(6, dishType, 0); }
  public static Offset<MiaoCsharp.WineData> EndWineData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<MiaoCsharp.WineData>(o);
  }
};


}