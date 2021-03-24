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
	public class NullableNilFormatter : IMessagePackFormatter<Nil?>
	{
		// Fields
		public static readonly IMessagePackFormatter<Nil?> Instance;
	
		// Constructors
		private NullableNilFormatter();
		static NullableNilFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, Nil? value, IFormatterResolver typeResolver);
		public Nil? Deserialize(byte[] bytes, int offset, IFormatterResolver typeResolver, out int readSize);
	}
}
