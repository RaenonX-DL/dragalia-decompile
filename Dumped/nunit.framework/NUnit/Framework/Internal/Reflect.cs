/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public static class Reflect
	{
		// Fields
		private static readonly BindingFlags AllMembers;
		private static readonly Type[] EmptyTypes;
		[CompilerGenerated]
		private static Func<Func<object>, object> _MethodCallWrapper_k__BackingField;
		[CompilerGenerated]
		private static Func<Type, object[], object> _ConstructorCallWrapper_k__BackingField;
	
		// Properties
		public static Func<Func<object>, object> MethodCallWrapper { [CompilerGenerated] get; }
		public static Func<Type, object[], object> ConstructorCallWrapper { [CompilerGenerated] get; }
	
		// Nested types
		private class BaseTypesFirstComparer : IComparer<MethodInfo>
		{
			// Constructors
			public BaseTypesFirstComparer();
	
			// Methods
			public int Compare(MethodInfo m1, MethodInfo m2);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2
		{
			// Fields
			public MethodInfo method;
			public object fixture;
			public object[] args;
	
			// Constructors
			public __c__DisplayClass2();
	
			// Methods
			public object _InvokeMethod_b__0();
		}
	
		// Constructors
		static Reflect();
	
		// Methods
		public static MethodInfo[] GetMethodsWithAttribute(Type fixtureType, Type attributeType, bool inherit);
		public static bool HasMethodWithAttribute(Type fixtureType, Type attributeType);
		public static object Construct(Type type);
		public static object Construct(Type type, object[] arguments);
		internal static Type[] GetTypeArray(object[] objects);
		public static object InvokeMethod(MethodInfo method, object fixture);
		public static object InvokeMethod(MethodInfo method, object fixture, params object[] args);
	}
}
