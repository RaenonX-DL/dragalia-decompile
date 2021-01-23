/*
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
	internal sealed class ReadNextMap : IReadNextDecoder
	{
		// Fields
		internal static readonly IReadNextDecoder Instance;
	
		// Constructors
		private ReadNextMap();
		static ReadNextMap();
	
		// Methods
		public int Read(byte[] bytes, int offset);
	}
}
