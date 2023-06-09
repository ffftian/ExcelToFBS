// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MiaoCsharp
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct DishData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static DishData GetRootAsDishData(ByteBuffer _bb) { return GetRootAsDishData(_bb, new DishData()); }
  public static DishData GetRootAsDishData(ByteBuffer _bb, DishData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DishData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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
  public string DishType { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDishTypeBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetDishTypeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetDishTypeArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<MiaoCsharp.DishData> CreateDishData(FlatBufferBuilder builder,
      int id = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset descriptionOffset = default(StringOffset),
      VectorOffset sourceItemOffset = default(VectorOffset),
      StringOffset iconOffset = default(StringOffset),
      int cost = 0,
      StringOffset dishTypeOffset = default(StringOffset)) {
    builder.StartTable(7);
    DishData.AddDishType(builder, dishTypeOffset);
    DishData.AddCost(builder, cost);
    DishData.AddIcon(builder, iconOffset);
    DishData.AddSourceItem(builder, sourceItemOffset);
    DishData.AddDescription(builder, descriptionOffset);
    DishData.AddName(builder, nameOffset);
    DishData.AddId(builder, id);
    return DishData.EndDishData(builder);
  }

  public static void StartDishData(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset) { builder.AddOffset(2, descriptionOffset.Value, 0); }
  public static void AddSourceItem(FlatBufferBuilder builder, VectorOffset sourceItemOffset) { builder.AddOffset(3, sourceItemOffset.Value, 0); }
  public static VectorOffset CreateSourceItemVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSourceItemVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartSourceItemVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(4, iconOffset.Value, 0); }
  public static void AddCost(FlatBufferBuilder builder, int cost) { builder.AddInt(5, cost, 0); }
  public static void AddDishType(FlatBufferBuilder builder, StringOffset dishTypeOffset) { builder.AddOffset(6, dishTypeOffset.Value, 0); }
  public static Offset<MiaoCsharp.DishData> EndDishData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<MiaoCsharp.DishData>(o);
  }
};


}
