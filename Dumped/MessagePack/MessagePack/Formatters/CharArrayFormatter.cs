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
	public sealed class CharArrayFormatter : IMessagePackFormatter<char[]>
	{
		// Fields
		public static readonly CharArrayFormatter Instance;
	
		// Constructors
		private CharArrayFormatter();
		static CharArrayFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, char[] value, IFormatterResolver formatterResolver);
		public char[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
