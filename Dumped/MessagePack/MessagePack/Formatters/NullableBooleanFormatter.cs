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
	public sealed class NullableBooleanFormatter : IMessagePackFormatter<bool?>
	{
		// Fields
		public static readonly NullableBooleanFormatter Instance;
	
		// Constructors
		private NullableBooleanFormatter();
		static NullableBooleanFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, bool? value, IFormatterResolver formatterResolver);
		public bool? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
