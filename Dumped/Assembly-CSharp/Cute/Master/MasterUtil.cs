/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Master
{
	public static class MasterUtil
	{
		// Fields
		public static Func<string, string> Localize;
		[CompilerGenerated]
		private static bool _IsStrictImport_k__BackingField;
	
		// Properties
		public static bool IsStrictImport { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<string, string> __9__5_0;
			public static Func<string, string, string> __9__5_1;
			public static Func<string, bool> __9__7_0;
			public static Func<string, int> __9__8_0;
			public static Func<string, float> __9__9_0;
			public static Func<string, bool> __9__10_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _SnakeToUpperCamel_b__5_0(string s);
			internal string _SnakeToUpperCamel_b__5_1(string s1, string s2);
			internal bool _ToStringArray_b__7_0(string s);
			internal int _ToIntArray_b__8_0(string s);
			internal float _ToFloatArray_b__9_0(string s);
			internal bool _ToBoolArray_b__10_0(string s);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public Type enumType;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal object _ToEnumArray_b__0(string s);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__21<T>
			where T : struct
		{
			// Fields
			public static readonly __c__21<T> __9;
			public static Func<string, T> __9__21_0;
	
			// Constructors
			static __c__21();
			public __c__21();
	
			// Methods
			internal T _ToEnumArray_b__21_0(string s);
		}
	
		// Methods
		public static string SnakeToUpperCamel(string src);
		public static bool IsGroupInstance(string path, out string baseName, out int id);
		public static string[] ToStringArray(string src);
		public static int[] ToIntArray(string src);
		public static float[] ToFloatArray(string src);
		public static bool[] ToBoolArray(string src);
		public static object[] ToEnumArray(string src, Type enumType);
		public static int ToInt(string[] values, int[] indexes, int index);
		public static float ToFloat(string[] values, int[] indexes, int index);
		public static string ToString(string[] values, int[] indexes, int index);
		public static bool ToBool(string[] values, int[] indexes, int index);
		public static T ToEnum<T>(string[] values, int[] indexes, int index)
			where T : struct;
		public static int[] ToIntArray(string[] values, int[] indexes, int index);
		public static float[] ToFloatArray(string[] values, int[] indexes, int index);
		public static string[] ToStringArray(string[] values, int[] indexes, int index);
		public static bool[] ToBoolArray(string[] values, int[] indexes, int index);
		public static T[] ToEnumArray<T>(string[] values, int[] indexes, int index)
			where T : struct;
	}
}
