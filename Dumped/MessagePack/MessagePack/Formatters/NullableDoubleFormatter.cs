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
	public sealed class NullableDoubleFormatter : IMessagePackFormatter<double?>
	{
		// Fields
		public static readonly NullableDoubleFormatter Instance;
	
		// Constructors
		private NullableDoubleFormatter();
		static NullableDoubleFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, double? value, IFormatterResolver formatterResolver);
		public double? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
