/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.668, Culture=neutral, PublicKeyToken=257b51d87d2e4d67

namespace ProtoBuf
{
	internal sealed class BufferPool
	{
		// Fields
		private static readonly object[] pool;
	
		// Constructors
		static BufferPool();
	
		// Methods
		internal static byte[] GetBuffer();
		internal static void ResizeAndFlushLeft(ref byte[] buffer, int toFitAtLeastBytes, int copyFromIndex, int copyBytes);
		internal static void ReleaseBufferToPool(ref byte[] buffer);
	}
}
