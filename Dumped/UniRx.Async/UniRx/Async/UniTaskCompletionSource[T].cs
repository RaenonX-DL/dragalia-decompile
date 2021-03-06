﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public class UniTaskCompletionSource<T> : IAwaiter<T>, IPromise<T>
	{
		// Fields
		private const int Pending = 0;
		private const int Succeeded = 1;
		private const int Faulted = 2;
		private const int Canceled = 3;
		private int state;
		private T value;
		private bool handled;
		private ExceptionHolder exception;
		private object continuation;
	
		// Properties
		bool IAwaiter.IsCompleted { get; }
		public UniTask<T> Task { get; }
		public UniTask UnitTask { get; }
		AwaiterStatus IAwaiter.Status { get; }
	
		// Constructors
		public UniTaskCompletionSource();
	
		// Methods
		[Conditional]
		internal void MarkHandled();
		T IAwaiter<T>.GetResult();
		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action);
		private void TryInvokeContinuation();
		public bool TrySetResult(T value);
		public bool TrySetException(Exception exception);
		public bool TrySetCanceled();
		public bool TrySetCanceled(OperationCanceledException exception);
		void IAwaiter.GetResult();
		void INotifyCompletion.OnCompleted(Action continuation);
	}
}
