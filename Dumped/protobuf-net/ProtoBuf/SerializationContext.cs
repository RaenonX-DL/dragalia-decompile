/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 39: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.668, Culture=neutral, PublicKeyToken=257b51d87d2e4d67

namespace ProtoBuf
{
	public sealed class SerializationContext
	{
		// Fields
		private bool frozen;
		private static readonly SerializationContext @default;
		private StreamingContextStates state;
	
		// Properties
		internal static SerializationContext Default { get; }
	
		// Constructors
		static SerializationContext();
		public SerializationContext();
	
		// Methods
		internal void Freeze();
	}
}
