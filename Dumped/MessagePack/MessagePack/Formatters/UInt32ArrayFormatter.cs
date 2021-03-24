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
	public sealed class UInt32ArrayFormatter : IMessagePackFormatter<uint[]>
	{
		// Fields
		public static readonly UInt32ArrayFormatter Instance;
	
		// Constructors
		private UInt32ArrayFormatter();
		static UInt32ArrayFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, uint[] value, IFormatterResolver formatterResolver);
		public uint[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
