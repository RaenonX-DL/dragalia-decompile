/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.668, Culture=neutral, PublicKeyToken=257b51d87d2e4d67

namespace ProtoBuf
{
	public sealed class BufferExtension : IExtension
	{
		// Fields
		private byte[] buffer;
	
		// Constructors
		public BufferExtension();
	
		// Methods
		Stream IExtension.BeginAppend();
		void IExtension.EndAppend(Stream stream, bool commit);
		Stream IExtension.BeginQuery();
		void IExtension.EndQuery(Stream stream);
	}
}
