/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using UnityEngine;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class EnumeratorAsyncExtensions
	{
		// Nested types
		private class EnumeratorAwaiter : IAwaiter, IPlayerLoopItem
		{
			// Fields
			private IEnumerator innerEnumerator;
			private CancellationToken cancellationToken;
			private Action continuation;
			private AwaiterStatus status;
			private ExceptionDispatchInfo exception;
			private static readonly FieldInfo waitForSeconds_Seconds;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Nested types
			[CompilerGenerated]
			private sealed class _ConsumeEnumerator_d__15 : IEnumerator<object>
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public IEnumerator enumerator;
				private IEnumerator _e2_5__2;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _ConsumeEnumerator_d__15(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			[CompilerGenerated]
			private sealed class _UnwrapWaitCustomYieldInstruction_d__16 : IEnumerator<object>
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public CustomYieldInstruction yieldInstruction;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _UnwrapWaitCustomYieldInstruction_d__16(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			[CompilerGenerated]
			private sealed class _UnwrapWaitForSeconds_d__18 : IEnumerator<object>
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public WaitForSeconds waitForSeconds;
				private float _second_5__2;
				private DateTimeOffset _startTime_5__3;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _UnwrapWaitForSeconds_d__18(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			[CompilerGenerated]
			private sealed class _UnwrapWaitAsyncOperation_d__19 : IEnumerator<object>
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public AsyncOperation asyncOperation;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _UnwrapWaitAsyncOperation_d__19(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			// Constructors
			public EnumeratorAwaiter(IEnumerator innerEnumerator, CancellationToken cancellationToken);
			static EnumeratorAwaiter();
	
			// Methods
			public void GetResult();
			public bool MoveNext();
			private void InvokeContinuation(AwaiterStatus status);
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
			[IteratorStateMachine]
			private static IEnumerator ConsumeEnumerator(IEnumerator enumerator);
			[IteratorStateMachine]
			private static IEnumerator UnwrapWaitCustomYieldInstruction(CustomYieldInstruction yieldInstruction);
			[IteratorStateMachine]
			private static IEnumerator UnwrapWaitForSeconds(WaitForSeconds waitForSeconds);
			[IteratorStateMachine]
			private static IEnumerator UnwrapWaitAsyncOperation(AsyncOperation asyncOperation);
		}
	
		// Extension methods
		public static IAwaiter GetAwaiter(this IEnumerator enumerator);
		public static UniTask ToUniTask(this IEnumerator enumerator);
		public static UniTask ConfigureAwait(this IEnumerator enumerator, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default);
	}
}
