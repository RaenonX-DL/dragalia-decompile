/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ProtoBuf.Meta;

// Image 39: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.668, Culture=neutral, PublicKeyToken=257b51d87d2e4d67

namespace ProtoBuf
{
	public sealed class ProtoWriter : IDisposable
	{
		// Fields
		private Stream dest;
		private TypeModel model;
		private readonly NetObjectCache netCache;
		private int fieldNumber;
		private int flushLock;
		private WireType wireType;
		private int depth;
		private MutableList recursionStack;
		private readonly SerializationContext context;
		private byte[] ioBuffer;
		private int ioIndex;
		private int position;
		private static readonly UTF8Encoding encoding;
		private int packedFieldNumber;
	
		// Constructors
		public ProtoWriter(Stream dest, TypeModel model, SerializationContext context);
		static ProtoWriter();
	
		// Methods
		public static void WriteFieldHeader(int fieldNumber, WireType wireType, ProtoWriter writer);
		internal static void WriteHeaderCore(int fieldNumber, WireType wireType, ProtoWriter writer);
		public static void WriteBytes(byte[] data, ProtoWriter writer);
		public static void WriteBytes(byte[] data, int offset, int length, ProtoWriter writer);
		private static void CopyRawFromStream(Stream source, ProtoWriter writer);
		private static void IncrementedAndReset(int length, ProtoWriter writer);
		public static SubItemToken StartSubItem(object instance, ProtoWriter writer);
		private void CheckRecursionStackAndPush(object instance);
		private void PopRecursionStack();
		private static SubItemToken StartSubItem(object instance, ProtoWriter writer, bool allowFixed);
		public static void EndSubItem(SubItemToken token, ProtoWriter writer);
		private static void EndSubItem(SubItemToken token, ProtoWriter writer, PrefixStyle style);
		void IDisposable.Dispose();
		private void Dispose();
		private static void DemandSpace(int required, ProtoWriter writer);
		public void Close();
		internal static void Flush(ProtoWriter writer);
		private static void WriteUInt32Variant(uint value, ProtoWriter writer);
		internal static uint Zig(int value);
		internal static ulong Zig(long value);
		private static void WriteUInt64Variant(ulong value, ProtoWriter writer);
		public static void WriteString(string value, ProtoWriter writer);
		public static void WriteInt64(long value, ProtoWriter writer);
		private static void WriteInt32ToBuffer(int value, byte[] buffer, int index);
		public static void WriteInt32(int value, ProtoWriter writer);
		public static void ThrowEnumException(ProtoWriter writer, object enumValue);
		internal static Exception CreateException(ProtoWriter writer);
		public static void AppendExtensionData(IExtensible instance, ProtoWriter writer);
	}
}
