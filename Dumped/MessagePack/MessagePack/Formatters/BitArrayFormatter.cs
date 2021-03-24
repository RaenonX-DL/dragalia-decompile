/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public sealed class BitArrayFormatter : IMessagePackFormatter<BitArray>
	{
		// Fields
		public static readonly IMessagePackFormatter<BitArray> Instance;
	
		// Constructors
		private BitArrayFormatter();
		static BitArrayFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, BitArray value, IFormatterResolver formatterResolver);
		public BitArray Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
