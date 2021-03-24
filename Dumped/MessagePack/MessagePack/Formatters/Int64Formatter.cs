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
	public sealed class Int64Formatter : IMessagePackFormatter<long>
	{
		// Fields
		public static readonly Int64Formatter Instance;
	
		// Constructors
		private Int64Formatter();
		static Int64Formatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, long value, IFormatterResolver formatterResolver);
		public long Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
