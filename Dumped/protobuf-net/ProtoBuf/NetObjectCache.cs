/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ProtoBuf.Meta;

// Image 39: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.668, Culture=neutral, PublicKeyToken=257b51d87d2e4d67

namespace ProtoBuf
{
	internal sealed class NetObjectCache
	{
		// Fields
		private MutableList underlyingList;
		private object rootObject;
		private int trapStartIndex;
		private Dictionary<string, int> stringKeys;
		private Dictionary<object, int> objectKeys;
	
		// Constructors
		public NetObjectCache();
	
		// Methods
		internal void RegisterTrappedObject(object value);
		internal void Clear();
	}
}
