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
	public sealed class StaticNullableFormatter<T> : IMessagePackFormatter<T?>
		where T : struct
	{
		// Fields
		private readonly IMessagePackFormatter<T> underlyingFormatter;
	
		// Constructors
		public StaticNullableFormatter(IMessagePackFormatter<T> underlyingFormatter);
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, T? value, IFormatterResolver formatterResolver);
		public T? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
