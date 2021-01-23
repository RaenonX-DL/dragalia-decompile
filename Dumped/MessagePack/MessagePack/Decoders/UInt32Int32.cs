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
	internal sealed class UInt32Int32 : IInt32Decoder
	{
		// Fields
		internal static readonly IInt32Decoder Instance;
	
		// Constructors
		private UInt32Int32();
		static UInt32Int32();
	
		// Methods
		public int Read(byte[] bytes, int offset, out int readSize);
	}
}
