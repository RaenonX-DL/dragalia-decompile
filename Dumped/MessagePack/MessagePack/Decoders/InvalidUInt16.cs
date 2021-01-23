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
	internal sealed class InvalidUInt16 : IUInt16Decoder
	{
		// Fields
		internal static readonly IUInt16Decoder Instance;
	
		// Constructors
		private InvalidUInt16();
		static InvalidUInt16();
	
		// Methods
		public ushort Read(byte[] bytes, int offset, out int readSize);
	}
}
