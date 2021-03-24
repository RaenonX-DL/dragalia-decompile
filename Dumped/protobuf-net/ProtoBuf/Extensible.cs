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
	public abstract class Extensible : IExtensible
	{
		// Fields
		private IExtension extensionObject;
	
		// Methods
		IExtension IExtensible.GetExtensionObject(bool createIfMissing);
		protected virtual IExtension GetExtensionObject(bool createIfMissing);
		public static IExtension GetExtensionObject(ref IExtension extensionObject, bool createIfMissing);
	}
}
