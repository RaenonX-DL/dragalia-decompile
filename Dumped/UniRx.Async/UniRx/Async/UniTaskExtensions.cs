/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using UniRx.Async.CompilerServices;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class UniTaskExtensions
	{
		// Nested types
		private class ToCoroutineEnumerator : IEnumerator
		{
			// Fields
			private bool completed;
			private UniTask task;
			private Action<Exception> exceptionHandler;
			private bool isStarted;
			private ExceptionDispatchInfo exception;
	
			// Properties
			public object Current { get; }
	
			// Nested types
			[CompilerGenerated]
			private struct _RunTask_d__6 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask task;
				public ToCoroutineEnumerator __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public ToCoroutineEnumerator(UniTask task, Action<Exception> exceptionHandler);
	
			// Methods
			private async UniTaskVoid RunTask(UniTask task);
			public bool MoveNext();
			public void Reset();
		}
	
		private class ToCoroutineEnumerator<T> : IEnumerator
		{
			// Fields
			private bool completed;
			private Action<T> resultHandler;
			private Action<Exception> exceptionHandler;
			private bool isStarted;
			private UniTask<T> task;
			private object current;
			private ExceptionDispatchInfo exception;
	
			// Properties
			public object Current { get; }
	
			// Nested types
			[CompilerGenerated]
			private struct _RunTask_d__8 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T> task;
				public ToCoroutineEnumerator<T> __4__this;
				private UniTask<T> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public ToCoroutineEnumerator(UniTask<T> task, Action<T> resultHandler, Action<Exception> exceptionHandler);
	
			// Methods
			private async UniTaskVoid RunTask(UniTask<T> task);
			public bool MoveNext();
			public void Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__1<T>
		{
			// Fields
			public static readonly __c__1<T> __9;
			public static Action<Task<T>, object> __9__1_0;
	
			// Constructors
			static __c__1();
			public __c__1();
	
			// Methods
			internal void _AsUniTask_b__1_0(Task<T> x, object state);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<Task, object> __9__2_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _AsUniTask_b__2_0(Task x, object state);
		}
	
		[CompilerGenerated]
		private struct _Timeout_d__6<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T> __t__builder;
			public TimeSpan timeout;
			public bool ignoreTimeScale;
			public PlayerLoopTiming timeoutCheckTiming;
			public UniTask<T> task;
			public CancellationTokenSource taskCancellationTokenSource;
			private CancellationTokenSource _delayCancellationTokenSource_5__2;
			[TupleElementNames]
			private UniTask<ValueTuple<bool, ValueTuple<bool, T>>> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _TimeoutWithoutException_d__7 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<bool> __t__builder;
			public UniTask task;
			public TimeSpan timeout;
			public bool ignoreTimeScale;
			public PlayerLoopTiming timeoutCheckTiming;
			public CancellationTokenSource taskCancellationTokenSource;
			[TupleElementNames]
			private UniTask<ValueTuple<bool, AsyncUnit>> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _TimeoutWithoutException_d__8<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<bool, T>> __t__builder;
			public TimeSpan timeout;
			public bool ignoreTimeScale;
			public PlayerLoopTiming timeoutCheckTiming;
			public UniTask<T> task;
			public CancellationTokenSource taskCancellationTokenSource;
			private CancellationTokenSource _delayCancellationTokenSource_5__2;
			[TupleElementNames]
			private UniTask<ValueTuple<bool, ValueTuple<bool, T>>> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ForgetCore_d__11 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskVoidMethodBuilder __t__builder;
			public UniTask task;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ForgetCoreWithCatch_d__12 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskVoidMethodBuilder __t__builder;
			public UniTask task;
			public bool handleExceptionOnMainThread;
			public Action<Exception> exceptionHandler;
			private object __7__wrap1;
			private int __7__wrap2;
			private UniTask.Awaiter __u__1;
			private Exception _ex_5__4;
			private SwitchToMainThreadAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ForgetCore_d__15<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskVoidMethodBuilder __t__builder;
			public UniTask<T> task;
			private UniTask<T> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ForgetCoreWithCatch_d__16<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskVoidMethodBuilder __t__builder;
			public UniTask<T> task;
			public bool handleExceptionOnMainThread;
			public Action<Exception> exceptionHandler;
			private object __7__wrap1;
			private int __7__wrap2;
			private UniTask<T> __u__1;
			private Exception _ex_5__4;
			private SwitchToMainThreadAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ContinueWith_d__17<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public Action<T> continuationFunction;
			public UniTask<T> task;
			private Action<T> __7__wrap1;
			private UniTask<T> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ContinueWith_d__18<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public Func<T, UniTask> continuationFunction;
			public UniTask<T> task;
			private Func<T, UniTask> __7__wrap1;
			private UniTask<T> __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ContinueWith_d__19<T, TR> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<TR> __t__builder;
			public Func<T, TR> continuationFunction;
			public UniTask<T> task;
			private Func<T, TR> __7__wrap1;
			private UniTask<T> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ContinueWith_d__20<T, TR> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<TR> __t__builder;
			public Func<T, UniTask<TR>> continuationFunction;
			public UniTask<T> task;
			private Func<T, UniTask<TR>> __7__wrap1;
			private UniTask<T> __u__1;
			private UniTask<TR> __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ContinueWith_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public UniTask task;
			public Action continuationFunction;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ContinueWith_d__22 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public UniTask task;
			public Func<UniTask> continuationFunction;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ContinueWith_d__23<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T> __t__builder;
			public UniTask task;
			public Func<T> continuationFunction;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ContinueWith_d__24<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T> __t__builder;
			public UniTask task;
			public Func<UniTask<T>> continuationFunction;
			private UniTask.Awaiter __u__1;
			private UniTask<T> __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ConfigureAwait_d__25 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public Task task;
			public PlayerLoopTiming timing;
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1;
			private YieldAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ConfigureAwait_d__26<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T> __t__builder;
			public Task<T> task;
			public PlayerLoopTiming timing;
			private T _v_5__2;
			private ConfiguredTaskAwaitable<T> __u__1;
			private YieldAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ConfigureAwait_d__27 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public UniTask task;
			public PlayerLoopTiming timing;
			private UniTask.Awaiter __u__1;
			private YieldAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ConfigureAwait_d__28<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T> __t__builder;
			public UniTask<T> task;
			public PlayerLoopTiming timing;
			private T _v_5__2;
			private UniTask<T> __u__1;
			private YieldAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _Unwrap_d__29<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T> __t__builder;
			public UniTask<UniTask<T>> task;
			private UniTask<UniTask<T>> __u__1;
			private UniTask<T> __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _Unwrap_d__30<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public UniTask<UniTask> task;
			private UniTask<UniTask> __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Methods
		private static async UniTaskVoid ForgetCore(UniTask task);
		private static async UniTaskVoid ForgetCoreWithCatch(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread);
		private static async UniTaskVoid ForgetCore<T>(UniTask<T> task);
		private static async UniTaskVoid ForgetCoreWithCatch<T>(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread);
	
		// Extension methods
		public static UniTask<AsyncUnit> AsAsyncUnitUniTask(this UniTask task);
		public static UniTask<T> AsUniTask<T>(this Task<T> task, bool useCurrentSynchronizationContext = true);
		public static UniTask AsUniTask(this Task task, bool useCurrentSynchronizationContext = true);
		public static IEnumerator ToCoroutine<T>(this UniTask<T> task, Action<T> resultHandler = null, Action<Exception> exceptionHandler = null);
		public static IEnumerator ToCoroutine(this UniTask task, Action<Exception> exceptionHandler = null);
		public static UniTask Timeout(this UniTask task, TimeSpan timeout, bool ignoreTimeScale = true, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, CancellationTokenSource taskCancellationTokenSource = null);
		public static async UniTask<T> Timeout<T>(this UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = true, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, CancellationTokenSource taskCancellationTokenSource = null);
		public static async UniTask<bool> TimeoutWithoutException(this UniTask task, TimeSpan timeout, bool ignoreTimeScale = true, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, CancellationTokenSource taskCancellationTokenSource = null);
		public static async UniTask<ValueTuple<bool, T>> TimeoutWithoutException<T>(this UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = true, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, CancellationTokenSource taskCancellationTokenSource = null);
		public static void Forget(this UniTask task);
		public static void Forget(this UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true);
		public static void Forget<T>(this UniTask<T> task);
		public static void Forget<T>(this UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true);
		public static async UniTask ContinueWith<T>(this UniTask<T> task, Action<T> continuationFunction);
		public static async UniTask ContinueWith<T>(this UniTask<T> task, Func<T, UniTask> continuationFunction);
		public static async UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, TR> continuationFunction);
		public static async UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, UniTask<TR>> continuationFunction);
		public static async UniTask ContinueWith(this UniTask task, Action continuationFunction);
		public static async UniTask ContinueWith(this UniTask task, Func<UniTask> continuationFunction);
		public static async UniTask<T> ContinueWith<T>(this UniTask task, Func<T> continuationFunction);
		public static async UniTask<T> ContinueWith<T>(this UniTask task, Func<UniTask<T>> continuationFunction);
		public static async UniTask ConfigureAwait(this Task task, PlayerLoopTiming timing);
		public static async UniTask<T> ConfigureAwait<T>(this Task<T> task, PlayerLoopTiming timing);
		public static async UniTask ConfigureAwait(this UniTask task, PlayerLoopTiming timing);
		public static async UniTask<T> ConfigureAwait<T>(this UniTask<T> task, PlayerLoopTiming timing);
		public static async UniTask<T> Unwrap<T>(this UniTask<UniTask<T>> task);
		public static async UniTask Unwrap<T>(this UniTask<UniTask> task);
		public static UniTask.Awaiter GetAwaiter(this IEnumerable<UniTask> tasks);
		public static UniTask<T[]> GetAwaiter<T>(this IEnumerable<UniTask<T>> tasks);
		public static UniTask<ValueTuple<T1, T2>> GetAwaiter<T1, T2>([TupleElementNames] this ValueTuple<UniTask<T1>, UniTask<T2>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>([TupleElementNames] this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>([TupleElementNames] this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>([TupleElementNames] this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>([TupleElementNames] this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>> tasks);
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>([TupleElementNames] this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>> tasks);
	}
}
