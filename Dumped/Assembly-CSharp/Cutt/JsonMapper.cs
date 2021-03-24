/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public static class JsonMapper
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _.cctor_b__0_0(float obj, JsonWriter writer);
			internal float _.cctor_b__0_1(double input);
			internal long _.cctor_b__0_2(int input);
		}
	
		// Constructors
		static JsonMapper();
	
		// Methods
		public static JsonData ToObject(string json);
		public static T ToObject<T>(string json);
		public static string ToJson(object obj);
	}
}
