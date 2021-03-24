/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MsgPack
{
	public static class ReflectionCache
	{
		// Fields
		private static Dictionary<Type, ReflectionCacheEntry> _cache;
	
		// Constructors
		static ReflectionCache();
	
		// Methods
		public static ReflectionCacheEntry Lookup(Type type);
		public static void RemoveCache(Type type);
		public static void Clear();
	}
}
