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
	public class ExceptionHelper
	{
		// Fields
		private static readonly Action<Exception> PreserveStackTrace;
		[CompilerGenerated]
		private static Action<Exception> CS___9__CachedAnonymousMethodDelegate1;
	
		// Constructors
		static ExceptionHelper();
	
		// Methods
		public static string BuildMessage(Exception exception);
		public static string BuildStackTrace(Exception exception);
		public static string GetStackTrace(Exception exception);
		private static List<Exception> FlattenExceptionHierarchy(Exception exception);
		[CompilerGenerated]
		private static void _.cctor_b__0(Exception _);
	}
}
