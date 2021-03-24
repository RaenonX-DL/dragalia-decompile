/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class DiagnosticsExtensions
	{
		// Fields
		private static bool displayFilenames;
		private static readonly Regex typeBeautifyRegex;
		private static readonly Dictionary<Type, string> builtInTypeNames;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<ParameterInfo, string> __9__4_0;
			public static Func<Type, string> __9__7_0;
			public static Func<Type, string> __9__7_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _CleanupAsyncStackTrace_b__4_0(ParameterInfo p);
			internal string _BeautifyType_b__7_0(Type x);
			internal string _BeautifyType_b__7_1(Type x);
		}
	
		// Constructors
		static DiagnosticsExtensions();
	
		// Methods
		private static bool IsAsync(MethodBase methodInfo);
		private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType);
		private static string BeautifyType(Type t, bool shortName);
		private static bool IgnoreLine(MethodBase methodInfo);
		private static string SimplifyPath(string path);
	
		// Extension methods
		public static string ToStringWithCleanupAsyncStackTrace(this Exception exception);
		public static string CleanupAsyncStackTrace(this StackTrace stackTrace);
	}
}
