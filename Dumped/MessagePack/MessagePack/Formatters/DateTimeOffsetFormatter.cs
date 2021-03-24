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
	public sealed class DateTimeOffsetFormatter : IMessagePackFormatter<DateTimeOffset>
	{
		// Fields
		public static readonly IMessagePackFormatter<DateTimeOffset> Instance;
	
		// Constructors
		private DateTimeOffsetFormatter();
		static DateTimeOffsetFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, DateTimeOffset value, IFormatterResolver formatterResolver);
		public DateTimeOffset Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
