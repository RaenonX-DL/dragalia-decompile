/*
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
	internal sealed class ReadNextStr32 : IReadNextDecoder
	{
		// Fields
		internal static readonly IReadNextDecoder Instance;
	
		// Constructors
		private ReadNextStr32();
		static ReadNextStr32();
	
		// Methods
		public int Read(byte[] bytes, int offset);
	}
}
