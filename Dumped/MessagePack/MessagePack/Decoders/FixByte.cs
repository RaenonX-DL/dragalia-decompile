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
	internal sealed class FixByte : IByteDecoder
	{
		// Fields
		internal static readonly IByteDecoder Instance;
	
		// Constructors
		private FixByte();
		static FixByte();
	
		// Methods
		public byte Read(byte[] bytes, int offset, out int readSize);
	}
}
