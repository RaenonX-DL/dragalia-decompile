﻿/*
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
	public sealed class Int32Formatter : IMessagePackFormatter<int>
	{
		// Fields
		public static readonly Int32Formatter Instance;
	
		// Constructors
		private Int32Formatter();
		static Int32Formatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, int value, IFormatterResolver formatterResolver);
		public int Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
