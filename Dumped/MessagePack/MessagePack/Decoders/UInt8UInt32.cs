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
	internal sealed class UInt8UInt32 : IUInt32Decoder
	{
		// Fields
		internal static readonly IUInt32Decoder Instance;
	
		// Constructors
		private UInt8UInt32();
		static UInt8UInt32();
	
		// Methods
		public uint Read(byte[] bytes, int offset, out int readSize);
	}
}
