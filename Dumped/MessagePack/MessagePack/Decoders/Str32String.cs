﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Decoders
{
	internal sealed class Str32String : IStringDecoder
	{
		// Fields
		internal static readonly IStringDecoder Instance;
	
		// Constructors
		private Str32String();
		static Str32String();
	
		// Methods
		public string Read(byte[] bytes, int offset, out int readSize);
	}
}
