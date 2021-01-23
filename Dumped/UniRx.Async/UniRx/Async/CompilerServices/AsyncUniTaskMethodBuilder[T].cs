/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UniRx.Async;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.CompilerServices
{
	public struct AsyncUniTaskMethodBuilder<T>
	{
		// Fields
		private T result;
		private UniTaskCompletionSource<T> promise;
		private Action moveNext;
	
		// Properties
		[DebuggerHidden]
		public UniTask<T> Task { get; }
	
		// Methods
		[DebuggerHidden]
		public static AsyncUniTaskMethodBuilder<T> Create();
		[DebuggerHidden]
		public void SetException(Exception exception);
		[DebuggerHidden]
		public void SetResult(T result);
		[DebuggerHidden]
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden]
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden]
		public void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
