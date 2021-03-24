/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public sealed class ProtoReader : IDisposable
	{
		// Fields
		private Stream source;
		private byte[] ioBuffer;
		private TypeModel model;
		private int fieldNumber;
		private int depth;
		private int dataRemaining;
		private int ioIndex;
		private int position;
		private int available;
		private int blockEnd;
		private WireType wireType;
		private bool isFixedLength;
		private bool internStrings;
		private NetObjectCache netCache;
		private uint trapCount;
		private Dictionary<string, string> stringInterner;
		private static readonly UTF8Encoding encoding;
		private static readonly byte[] EmptyBlob;
	
		// Properties
		public int FieldNumber { get; }
	
		// Constructors
		static ProtoReader();
	
		// Methods
		public void Dispose();
		internal int TryReadUInt32VariantWithoutMoving(bool trimNegative, out uint value);
		private uint ReadUInt32Variant(bool trimNegative);
		private bool TryReadUInt32Variant(out uint value);
		internal void Ensure(int count, bool strict);
		public int ReadInt32();
		private static int Zag(uint ziggedValue);
		private static long Zag(ulong ziggedValue);
		public long ReadInt64();
		private int TryReadUInt64VariantWithoutMoving(out ulong value);
		private ulong ReadUInt64Variant();
		private string Intern(string value);
		public string ReadString();
		public void ThrowEnumException(Type type, int value);
		private Exception CreateWireTypeException();
		private Exception CreateException(string message);
		public static void EndSubItem(SubItemToken token, ProtoReader reader);
		public static SubItemToken StartSubItem(ProtoReader reader);
		public int ReadFieldHeader();
		public bool TryReadFieldHeader(int field);
		public static byte[] AppendBytes(byte[] value, ProtoReader reader);
		internal static Exception AddErrorData(Exception exception, ProtoReader source);
		private static Exception EoF(ProtoReader source);
		public void AppendExtensionData(IExtensible instance);
		private void AppendExtensionField(ProtoWriter writer);
		public static void NoteObject(object value, ProtoReader reader);
	}
}
