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
	public sealed class NullableStringFormatter : IMessagePackFormatter<string>
	{
		// Fields
		public static readonly NullableStringFormatter Instance;
	
		// Constructors
		private NullableStringFormatter();
		static NullableStringFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, string value, IFormatterResolver typeResolver);
		public string Deserialize(byte[] bytes, int offset, IFormatterResolver typeResolver, out int readSize);
	}
}
