/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using MessagePack.Formatters;
using UnityEngine;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Unity
{
	public sealed class ColorFormatter : IMessagePackFormatter<Color>
	{
		// Constructors
		public ColorFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, Color value, IFormatterResolver formatterResolver);
		public Color Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
