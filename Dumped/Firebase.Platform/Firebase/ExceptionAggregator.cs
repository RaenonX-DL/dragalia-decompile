/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 39: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	internal class ExceptionAggregator
	{
		// Fields
		[ThreadStatic]
		private static List<Exception> threadLocalExceptions;
	
		// Properties
		private static List<Exception> Exceptions { get; }
	
		// Constructors
		static ExceptionAggregator();
	
		// Methods
		public static Exception GetAndClearPendingExceptions();
		public static void ThrowAndClearPendingExceptions();
		public static Exception LogException(Exception exception);
		public static void Wrap(Action action);
	}
}
