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
	public sealed class CharFormatter : IMessagePackFormatter<char>
	{
		// Fields
		public static readonly CharFormatter Instance;
	
		// Constructors
		private CharFormatter();
		static CharFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, char value, IFormatterResolver formatterResolver);
		public char Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
