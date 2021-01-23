/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public sealed class ByteArraySegmentFormatter : IMessagePackFormatter<ArraySegment<byte>>
	{
		// Fields
		public static readonly ByteArraySegmentFormatter Instance;
	
		// Constructors
		private ByteArraySegmentFormatter();
		static ByteArraySegmentFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, ArraySegment<byte> value, IFormatterResolver formatterResolver);
		public ArraySegment<byte> Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
