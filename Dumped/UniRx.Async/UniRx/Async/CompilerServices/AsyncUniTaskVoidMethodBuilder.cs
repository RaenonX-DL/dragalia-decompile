/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UniRx.Async;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.CompilerServices
{
	public struct AsyncUniTaskVoidMethodBuilder
	{
		// Fields
		private Action moveNext;
	
		// Properties
		public UniTaskVoid Task { get; }
	
		// Methods
		[DebuggerHidden]
		public static AsyncUniTaskVoidMethodBuilder Create();
		[DebuggerHidden]
		public void SetException(Exception exception);
		[DebuggerHidden]
		public void SetResult();
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
