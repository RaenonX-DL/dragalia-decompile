﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Internal
{
	internal static class LZ4MemoryPool
	{
		// Fields
		[ThreadStatic]
		private static byte[] lz4buffer;
	
		// Constructors
		static LZ4MemoryPool();
	
		// Methods
		public static byte[] GetBuffer();
	}
}
