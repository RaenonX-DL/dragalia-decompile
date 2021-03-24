/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class UniTaskScheduler
	{
		// Fields
		[CompilerGenerated]
		private static Action<Exception> UnobservedTaskException;
		public static bool PropagateOperationCanceledException;
		public static LogType UnobservedExceptionWriteLogType;
		public static bool DispatchUnityMainThread;
		private static readonly SendOrPostCallback handleExceptionInvoke;
	
		// Events
		public static event Action<Exception> UnobservedTaskException {
			add;
			remove;
		}
	
		// Constructors
		static UniTaskScheduler();
	
		// Methods
		internal static void PublishUnobservedTaskException(Exception ex);
		private static void InvokeUnobservedTaskException(object state);
	}
}
