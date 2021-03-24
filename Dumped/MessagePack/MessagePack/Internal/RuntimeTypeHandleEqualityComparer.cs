/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Internal
{
	public class RuntimeTypeHandleEqualityComparer : IEqualityComparer<RuntimeTypeHandle>
	{
		// Fields
		public static IEqualityComparer<RuntimeTypeHandle> Default;
	
		// Constructors
		private RuntimeTypeHandleEqualityComparer();
		static RuntimeTypeHandleEqualityComparer();
	
		// Methods
		public bool Equals(RuntimeTypeHandle x, RuntimeTypeHandle y);
		public int GetHashCode(RuntimeTypeHandle obj);
	}
}
