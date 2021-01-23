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

namespace NUnit.Compatibility
{
	public static class AdditionalTypeExtensions
	{
		// Fields
		private static Dictionary<Type, List<Type>> convertibleValueTypes;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1
		{
			// Fields
			public Type to;
	
			// Constructors
			public __c__DisplayClass1();
	
			// Methods
			public bool _IsCastableFrom_b__0(MethodInfo m);
		}
	
		// Constructors
		static AdditionalTypeExtensions();
	
		// Extension methods
		public static bool ParametersMatch(this ParameterInfo[] pinfos, Type[] ptypes);
		public static bool IsCastableFrom(this Type to, Type from);
	}
}
