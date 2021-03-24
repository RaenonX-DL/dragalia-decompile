/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Master
{
	public static class TypeCache
	{
		// Fields
		private static Dictionary<string, Type> typeCachesFullName;
		private static Dictionary<string, Type> typeCachesName;
	
		// Methods
		public static Type GetType(string name);
		public static void ForEach(Action<Type> action);
		private static void CreateCache();
	}
}
