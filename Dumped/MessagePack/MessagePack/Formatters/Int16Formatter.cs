/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public sealed class Int16Formatter : IMessagePackFormatter<short>
	{
		// Fields
		public static readonly Int16Formatter Instance;
	
		// Constructors
		private Int16Formatter();
		static Int16Formatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, short value, IFormatterResolver formatterResolver);
		public short Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
