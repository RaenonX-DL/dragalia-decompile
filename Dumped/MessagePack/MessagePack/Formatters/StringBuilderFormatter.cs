/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using MessagePack;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters
{
	public sealed class StringBuilderFormatter : IMessagePackFormatter<StringBuilder>
	{
		// Fields
		public static readonly IMessagePackFormatter<StringBuilder> Instance;
	
		// Constructors
		private StringBuilderFormatter();
		static StringBuilderFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, StringBuilder value, IFormatterResolver formatterResolver);
		public StringBuilder Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
