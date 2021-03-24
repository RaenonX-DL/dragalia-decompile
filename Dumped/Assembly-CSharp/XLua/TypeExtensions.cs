/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	internal static class TypeExtensions
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<Type, string> __9__12_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _GetFriendlyName_b__12_0(Type x);
		}
	
		// Extension methods
		public static bool IsValueType(this Type type);
		public static bool IsEnum(this Type type);
		public static bool IsPrimitive(this Type type);
		public static bool IsAbstract(this Type type);
		public static bool IsSealed(this Type type);
		public static bool IsInterface(this Type type);
		public static bool IsClass(this Type type);
		public static Type BaseType(this Type type);
		public static bool IsGenericType(this Type type);
		public static bool IsGenericTypeDefinition(this Type type);
		public static bool IsNestedPublic(this Type type);
		public static bool IsPublic(this Type type);
		public static string GetFriendlyName(this Type type);
	}
}
