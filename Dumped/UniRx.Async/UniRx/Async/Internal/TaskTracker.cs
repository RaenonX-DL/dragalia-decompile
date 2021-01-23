/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	public static class TaskTracker
	{
		// Fields
		[TupleElementNames]
		private static List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>> listPool;
		[TupleElementNames]
		private static readonly WeakDictionary<IAwaiter, ValueTuple<int, DateTime, string>> tracking;
		private static bool dirty;
	
		// Constructors
		static TaskTracker();
	
		// Methods
		[Conditional]
		public static void TrackActiveTask(IAwaiter task, int skipFrame = 1);
		[Conditional]
		public static void TrackActiveTask(IAwaiter task, string stackTrace);
		public static string CaptureStackTrace(int skipFrame);
		[Conditional]
		public static void RemoveTracking(IAwaiter task);
		public static bool CheckAndResetDirty();
		public static void ForEachActiveTask(Action<int, string, AwaiterStatus, DateTime, string> action);
	}
}
