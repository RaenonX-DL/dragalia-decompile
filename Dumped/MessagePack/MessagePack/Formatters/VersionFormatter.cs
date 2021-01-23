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
	public sealed class VersionFormatter : IMessagePackFormatter<Version>
	{
		// Fields
		public static readonly IMessagePackFormatter<Version> Instance;
	
		// Constructors
		private VersionFormatter();
		static VersionFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, Version value, IFormatterResolver formatterResolver);
		public Version Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
