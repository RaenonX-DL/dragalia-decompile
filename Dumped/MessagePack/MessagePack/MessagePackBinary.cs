/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack.Decoders;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack
{
	public static class MessagePackBinary
	{
		// Fields
		private static readonly IMapHeaderDecoder[] mapHeaderDecoders;
		private static readonly IArrayHeaderDecoder[] arrayHeaderDecoders;
		private static readonly IBooleanDecoder[] booleanDecoders;
		private static readonly IByteDecoder[] byteDecoders;
		private static readonly IBytesDecoder[] bytesDecoders;
		private static readonly IBytesSegmentDecoder[] bytesSegmentDecoders;
		private static readonly ISByteDecoder[] sbyteDecoders;
		private static readonly ISingleDecoder[] singleDecoders;
		private static readonly IDoubleDecoder[] doubleDecoders;
		private static readonly IInt16Decoder[] int16Decoders;
		private static readonly IInt32Decoder[] int32Decoders;
		private static readonly IInt64Decoder[] int64Decoders;
		private static readonly IUInt16Decoder[] uint16Decoders;
		private static readonly IUInt32Decoder[] uint32Decoders;
		private static readonly IUInt64Decoder[] uint64Decoders;
		private static readonly IStringDecoder[] stringDecoders;
		private static readonly IStringSegmentDecoder[] stringSegmentDecoders;
		private static readonly IExtDecoder[] extDecoders;
		private static readonly IExtHeaderDecoder[] extHeaderDecoders;
		private static readonly IDateTimeDecoder[] dateTimeDecoders;
		private static readonly IReadNextDecoder[] readNextDecoders;
	
		// Constructors
		static MessagePackBinary();
	
		// Methods
		public static void EnsureCapacity(ref byte[] bytes, int offset, int appendLength);
		public static void FastResize(ref byte[] array, int newSize);
		public static byte[] FastCloneWithResize(byte[] array, int newSize);
		public static MessagePackType GetMessagePackType(byte[] bytes, int offset);
		public static int ReadNext(byte[] bytes, int offset);
		public static int ReadNextBlock(byte[] bytes, int offset);
		public static int WriteNil(ref byte[] bytes, int offset);
		public static Nil ReadNil(byte[] bytes, int offset, out int readSize);
		public static bool IsNil(byte[] bytes, int offset);
		public static int WriteFixedMapHeaderUnsafe(ref byte[] bytes, int offset, int count);
		public static int WriteMapHeader(ref byte[] bytes, int offset, int count);
		public static int WriteMapHeader(ref byte[] bytes, int offset, uint count);
		public static int ReadMapHeader(byte[] bytes, int offset, out int readSize);
		public static int GetArrayHeaderLength(int count);
		public static int WriteFixedArrayHeaderUnsafe(ref byte[] bytes, int offset, int count);
		public static int WriteArrayHeader(ref byte[] bytes, int offset, int count);
		public static int WriteArrayHeader(ref byte[] bytes, int offset, uint count);
		public static int ReadArrayHeader(byte[] bytes, int offset, out int readSize);
		public static int WriteBoolean(ref byte[] bytes, int offset, bool value);
		public static bool ReadBoolean(byte[] bytes, int offset, out int readSize);
		public static int WriteByte(ref byte[] bytes, int offset, byte value);
		public static int WriteByteForceByteBlock(ref byte[] bytes, int offset, byte value);
		public static byte ReadByte(byte[] bytes, int offset, out int readSize);
		public static int WriteBytes(ref byte[] bytes, int offset, byte[] value);
		public static int WriteBytes(ref byte[] dest, int dstOffset, byte[] src, int srcOffset, int count);
		public static byte[] ReadBytes(byte[] bytes, int offset, out int readSize);
		public static int WriteSByte(ref byte[] bytes, int offset, sbyte value);
		public static int WriteSByteForceSByteBlock(ref byte[] bytes, int offset, sbyte value);
		public static sbyte ReadSByte(byte[] bytes, int offset, out int readSize);
		public static int WriteSingle(ref byte[] bytes, int offset, float value);
		public static float ReadSingle(byte[] bytes, int offset, out int readSize);
		public static int WriteDouble(ref byte[] bytes, int offset, double value);
		public static double ReadDouble(byte[] bytes, int offset, out int readSize);
		public static int WriteInt16(ref byte[] bytes, int offset, short value);
		public static int WriteInt16ForceInt16Block(ref byte[] bytes, int offset, short value);
		public static short ReadInt16(byte[] bytes, int offset, out int readSize);
		public static int WriteInt32(ref byte[] bytes, int offset, int value);
		public static int WriteInt32ForceInt32Block(ref byte[] bytes, int offset, int value);
		public static int ReadInt32(byte[] bytes, int offset, out int readSize);
		public static int WriteInt64(ref byte[] bytes, int offset, long value);
		public static int WriteInt64ForceInt64Block(ref byte[] bytes, int offset, long value);
		public static long ReadInt64(byte[] bytes, int offset, out int readSize);
		public static int WriteUInt16(ref byte[] bytes, int offset, ushort value);
		public static int WriteUInt16ForceUInt16Block(ref byte[] bytes, int offset, ushort value);
		public static ushort ReadUInt16(byte[] bytes, int offset, out int readSize);
		public static int WriteUInt32(ref byte[] bytes, int offset, uint value);
		public static int WriteUInt32ForceUInt32Block(ref byte[] bytes, int offset, uint value);
		public static uint ReadUInt32(byte[] bytes, int offset, out int readSize);
		public static int WriteUInt64(ref byte[] bytes, int offset, ulong value);
		public static int WriteUInt64ForceUInt64Block(ref byte[] bytes, int offset, ulong value);
		public static ulong ReadUInt64(byte[] bytes, int offset, out int readSize);
		public static int WriteChar(ref byte[] bytes, int offset, char value);
		public static char ReadChar(byte[] bytes, int offset, out int readSize);
		public static int WriteStringBytes(ref byte[] bytes, int offset, byte[] utf8stringBytes);
		public static int WriteString(ref byte[] bytes, int offset, string value);
		public static string ReadString(byte[] bytes, int offset, out int readSize);
		public static ArraySegment<byte> ReadStringSegment(byte[] bytes, int offset, out int readSize);
		public static int WriteExtensionFormatHeaderForceExt32Block(ref byte[] bytes, int offset, sbyte typeCode, int dataLength);
		public static ExtensionHeader ReadExtensionFormatHeader(byte[] bytes, int offset, out int readSize);
		public static int WriteDateTime(ref byte[] bytes, int offset, DateTime dateTime);
		public static DateTime ReadDateTime(byte[] bytes, int offset, out int readSize);
	}
}
