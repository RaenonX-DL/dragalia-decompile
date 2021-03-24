/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public sealed class PrimitiveObjectFormatter : IMessagePackFormatter<object>
	{
		// Fields
		public static readonly IMessagePackFormatter<object> Instance;
		private static readonly Dictionary<Type, int> typeToJumpCode;
	
		// Constructors
		private PrimitiveObjectFormatter();
		static PrimitiveObjectFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, object value, IFormatterResolver formatterResolver);
		public object Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
