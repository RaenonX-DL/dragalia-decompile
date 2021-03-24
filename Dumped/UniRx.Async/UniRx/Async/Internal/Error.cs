/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal static class Error
	{
		// Methods
		public static void ThrowArgumentNullException<T>(T value, string paramName)
			where T : class;
		private static void ThrowArgumentNullExceptionCore(string paramName);
		public static void ThrowArgumentException<T>(string message);
		public static void ThrowNotYetCompleted();
		public static T ThrowNotYetCompleted<T>();
		public static void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField)
			where T : class;
		private static void ThrowInvalidOperationExceptionCore(string message);
		public static void ThrowOperationCanceledException();
	}
}
