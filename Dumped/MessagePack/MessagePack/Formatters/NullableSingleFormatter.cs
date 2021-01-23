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
	public sealed class NullableSingleFormatter : IMessagePackFormatter<float?>
	{
		// Fields
		public static readonly NullableSingleFormatter Instance;
	
		// Constructors
		private NullableSingleFormatter();
		static NullableSingleFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, float? value, IFormatterResolver formatterResolver);
		public float? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
