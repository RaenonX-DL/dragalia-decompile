﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Decoders
{
	internal sealed class Str8StringSegment : IStringSegmentDecoder
	{
		// Fields
		internal static readonly IStringSegmentDecoder Instance;
	
		// Constructors
		private Str8StringSegment();
		static Str8StringSegment();
	
		// Methods
		public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize);
	}
}