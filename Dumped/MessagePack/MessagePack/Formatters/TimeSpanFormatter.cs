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
	public sealed class TimeSpanFormatter : IMessagePackFormatter<TimeSpan>
	{
		// Fields
		public static readonly IMessagePackFormatter<TimeSpan> Instance;
	
		// Constructors
		private TimeSpanFormatter();
		static TimeSpanFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, TimeSpan value, IFormatterResolver formatterResolver);
		public TimeSpan Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
