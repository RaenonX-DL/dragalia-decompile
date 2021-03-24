/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Master
{
	public static class MasterUtil
	{
		// Fields
		public static Func<string, string> Localize;
		[CompilerGenerated]
		private static bool _IsStrictImport_k__BackingField;
		private static readonly char[] separator;
		private static readonly NumberStyles intStyle;
		private static readonly NumberStyles floatStyle;
		private static readonly CultureInfo culture;
		private static readonly Regex groupMatch;
	
		// Properties
		public static bool IsStrictImport { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public class EnumCache<T>
		{
			// Fields
			private static Dictionary<string, T> cache;
	
			// Constructors
			public EnumCache();
			static EnumCache();
	
			// Methods
			public static T Get(string s);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<string, string> __9__11_0;
			public static Func<string, string, string> __9__11_1;
			public static Func<string, string> __9__13_0;
			public static Func<string, int> __9__14_0;
			public static Func<string, float> __9__15_0;
			public static Func<string, bool> __9__16_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _SnakeToUpperCamel_b__11_0(string s);
			internal string _SnakeToUpperCamel_b__11_1(string s1, string s2);
			internal string _ToStringArray_b__13_0(string s);
			internal int _ToIntArray_b__14_0(string s);
			internal float _ToFloatArray_b__15_0(string s);
			internal bool _ToBoolArray_b__16_0(string s);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public Type enumType;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal object _ToEnumArray_b__0(string s);
		}
	
		// Constructors
		static MasterUtil();
	
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
