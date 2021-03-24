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
using UniRx.Async.CompilerServices;
using UniRx.Async.Internal;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	[AsyncMethodBuilder]
	public struct UniTask : IEquatable<UniRx.Async.UniTask>
	{
		// Fields
		private static readonly UniTask<AsyncUnit> DefaultAsyncUnitTask;
		private readonly IAwaiter awaiter;
		private static readonly UniTask CanceledUniTask;
	
		// Properties
		[DebuggerHidden]
		public AwaiterStatus Status { get; }
		[DebuggerHidden]
		public bool IsCompleted { get; }
		public static UniTask CompletedTask { get; }
	
		// Nested types
		private class AsyncUnitAwaiter : IAwaiter<AsyncUnit>
		{
			// Fields
			private readonly IAwaiter awaiter;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public AsyncUnitAwaiter(IAwaiter awaiter);
	
			// Methods
			public AsyncUnit GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
			void IAwaiter.GetResult();
		}
	
		private class IsCanceledAwaiter : IAwaiter<bool>
		{
			// Fields
			private readonly IAwaiter awaiter;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public IsCanceledAwaiter(IAwaiter awaiter);
	
			// Methods
			public bool GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
			void IAwaiter.GetResult();
		}
	
		public struct Awaiter : IAwaiter
		{
			// Fields
			private readonly UniTask task;
	
			// Properties
			[DebuggerHidden]
			public bool IsCompleted { get; }
			[DebuggerHidden]
			public AwaiterStatus Status { get; }
	
			// Constructors
			[DebuggerHidden]
			public Awaiter(UniTask task);
	
			// Methods
			[DebuggerHidden]
			public void GetResult();
			[DebuggerHidden]
			public void OnCompleted(Action continuation);
			[DebuggerHidden]
			public void UnsafeOnCompleted(Action continuation);
		}
	
		private class YieldPromise : PlayerLoopReusablePromiseBase
		{
			// Constructors
			public YieldPromise(PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class DelayFramePromise : PlayerLoopReusablePromiseBase<int>
		{
			// Fields
			private readonly int delayFrameCount;
			private int currentFrameCount;
	
			// Constructors
			public DelayFramePromise(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class DelayPromise : PlayerLoopReusablePromiseBase
		{
			// Fields
			private readonly float delayFrameTimeSpan;
			private float elapsed;
	
			// Constructors
			public DelayPromise(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class DelayIgnoreTimeScalePromise : PlayerLoopReusablePromiseBase
		{
			// Fields
			private readonly float delayFrameTimeSpan;
			private float elapsed;
	
			// Constructors
			public DelayIgnoreTimeScalePromise(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private static class CanceledUniTaskCache<T>
		{
			// Fields
			public static readonly UniTask<T> Task;
	
			// Constructors
			static CanceledUniTaskCache();
		}
	
		private class WaitUntilPromise : PlayerLoopReusablePromiseBase
		{
			// Fields
			private readonly Func<bool> predicate;
	
			// Constructors
			public WaitUntilPromise(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class WaitWhilePromise : PlayerLoopReusablePromiseBase
		{
			// Fields
			private readonly Func<bool> predicate;
	
			// Constructors
			public WaitWhilePromise(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class WaitUntilValueChangedUnityObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U>
		{
			// Fields
			private readonly T target;
			private readonly Func<T, U> monitorFunction;
			private readonly IEqualityComparer<U> equalityComparer;
			private U currentValue;
	
			// Constructors
			public WaitUntilValueChangedUnityObjectPromise(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class WaitUntilValueChangedStandardObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U>
			where T : class
		{
			// Fields
			private readonly WeakReference<T> target;
			private readonly Func<T, U> monitorFunction;
			private readonly IEqualityComparer<U> equalityComparer;
			private U currentValue;
	
			// Constructors
			public WaitUntilValueChangedStandardObjectPromise(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken);
	
			// Methods
			protected override void OnRunningStart();
			public override bool MoveNext();
		}
	
		private class WhenAllPromise<T>
		{
			// Fields
			private readonly T[] result;
			private int completeCount;
			private Action whenComplete;
			private ExceptionDispatchInfo exception;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAllPromise<T> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T> parent);
	
				// Methods
				public T[] GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask_d__6 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T> task;
				public WhenAllPromise<T> __4__this;
				public int index;
				private UniTask<T> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T>[] tasks, int tasksLength);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask(UniTask<T> task, int index);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise
		{
			// Fields
			private int completeCount;
			private int resultLength;
			private Action whenComplete;
			private ExceptionDispatchInfo exception;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAllPromise parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise parent);
	
				// Methods
				public void GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask_d__6 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask task;
				public WhenAllPromise __4__this;
				private Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask[] tasks, int tasksLength);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask(UniTask task, int index);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2>
		{
			// Fields
			private const int MaxCount = 2;
			private T1 result1;
			private T2 result2;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAllPromise<T1, T2> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2> parent);
	
				// Methods
				public ValueTuple<T1, T2> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask1Async_d__9 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2Async_d__11 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask2Async(UniTask<T2> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3>
		{
			// Fields
			private const int MaxCount = 3;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAllPromise<T1, T2, T3> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask1Async_d__10 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2Async_d__12 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3Async_d__14 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask3Async(UniTask<T3> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4>
		{
			// Fields
			private const int MaxCount = 4;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAllPromise<T1, T2, T3, T4> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3, T4> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3, T4> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask1Async_d__11 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2Async_d__13 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3Async_d__15 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask4Async_d__17 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4> __4__this;
				private UniTask<T4> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			private async UniTaskVoid RunTask4Async(UniTask<T4> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5>
		{
			// Fields
			private const int MaxCount = 5;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAllPromise<T1, T2, T3, T4, T5> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3, T4, T5> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask1Async_d__12 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2Async_d__14 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3Async_d__16 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask4Async_d__18 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> __4__this;
				private UniTask<T4> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask5Async_d__20 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5> __4__this;
				private UniTask<T5> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			private async UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			private async UniTaskVoid RunTask5Async(UniTask<T5> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5, T6>
		{
			// Fields
			private const int MaxCount = 6;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private T6 result6;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAllPromise<T1, T2, T3, T4, T5, T6> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5, T6> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3, T4, T5, T6> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask1Async_d__13 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2Async_d__15 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3Async_d__17 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask4Async_d__19 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T4> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask5Async_d__21 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T5> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask6Async_d__23 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T6> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T6> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			private async UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			private async UniTaskVoid RunTask5Async(UniTask<T5> task);
			private void RunTask6(UniTask<T6> task);
			private async UniTaskVoid RunTask6Async(UniTask<T6> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7>
		{
			// Fields
			private const int MaxCount = 7;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private T6 result6;
			private T7 result7;
			private ExceptionDispatchInfo exception;
			private int completeCount;
			private Action whenComplete;
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> parent);
	
				// Methods
				public ValueTuple<T1, T2, T3, T4, T5, T6, T7> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask1Async_d__14 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2Async_d__16 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3Async_d__18 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask4Async_d__20 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T4> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T4> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask5Async_d__22 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T5> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T5> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask6Async_d__24 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T6> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T6> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask7Async_d__26 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T7> task;
				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T7> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
	
			// Methods
			private void TryCallContinuation();
			private void RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask1Async(UniTask<T1> task);
			private void RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask2Async(UniTask<T2> task);
			private void RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask3Async(UniTask<T3> task);
			private void RunTask4(UniTask<T4> task);
			private async UniTaskVoid RunTask4Async(UniTask<T4> task);
			private void RunTask5(UniTask<T5> task);
			private async UniTaskVoid RunTask5Async(UniTask<T5> task);
			private void RunTask6(UniTask<T6> task);
			private async UniTaskVoid RunTask6Async(UniTask<T6> task);
			private void RunTask7(UniTask<T7> task);
			private async UniTaskVoid RunTask7Async(UniTask<T7> task);
			public Awaiter GetAwaiter();
		}
	
		private class UnitWhenAnyPromise<T0>
		{
			// Fields
			private T0 result0;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private UnitWhenAnyPromise<T0> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(UnitWhenAnyPromise<T0> parent);
	
				// Methods
				public ValueTuple<bool, T0> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask0_d__9 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T0> task;
				public UnitWhenAnyPromise<T0> __4__this;
				private UniTask<T0> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask1_d__10 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask task;
				public UnitWhenAnyPromise<T0> __4__this;
				private Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public UnitWhenAnyPromise(UniTask<T0> task0, UniTask task1);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask0(UniTask<T0> task);
			private async UniTaskVoid RunTask1(UniTask task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T>
		{
			// Fields
			private T result;
			private int completeCount;
			private int winArgumentIndex;
			private Action whenComplete;
			private ExceptionDispatchInfo exception;
	
			// Properties
			public bool IsComplete { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise<T> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T> parent);
	
				// Methods
				public ValueTuple<int, T> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask_d__8 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T> task;
				public WhenAnyPromise<T> __4__this;
				public int index;
				private UniTask<T> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T>[] tasks);
	
			// Methods
			private async UniTaskVoid RunTask(UniTask<T> task, int index);
			private void TryCallContinuation();
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise
		{
			// Fields
			private int completeCount;
			private int winArgumentIndex;
			private Action whenComplete;
			private ExceptionDispatchInfo exception;
	
			// Properties
			public bool IsComplete { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise parent);
	
				// Methods
				public int GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask_d__7 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask task;
				public WhenAnyPromise __4__this;
				public int index;
				private Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask[] tasks);
	
			// Methods
			private async UniTaskVoid RunTask(UniTask task, int index);
			private void TryCallContinuation();
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1>
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise<T0, T1> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask0_d__10 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1> __4__this;
				private UniTask<T0> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask1_d__11 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask0(UniTask<T0> task);
			private async UniTaskVoid RunTask1(UniTask<T1> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2>
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask0_d__11 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2> __4__this;
				private UniTask<T0> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask1_d__12 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2_d__13 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask0(UniTask<T0> task);
			private async UniTaskVoid RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask2(UniTask<T2> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3>
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask0_d__12 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3> __4__this;
				private UniTask<T0> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask1_d__13 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2_d__14 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3_d__15 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask0(UniTask<T0> task);
			private async UniTaskVoid RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask3(UniTask<T3> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4>
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3, T4> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask0_d__13 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> __4__this;
				private UniTask<T0> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask1_d__14 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2_d__15 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3_d__16 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask4_d__17 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4> __4__this;
				private UniTask<T4> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask0(UniTask<T0> task);
			private async UniTaskVoid RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask4(UniTask<T4> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5>
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask0_d__14 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> __4__this;
				private UniTask<T0> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask1_d__15 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2_d__16 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3_d__17 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask4_d__18 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> __4__this;
				private UniTask<T4> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask5_d__19 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> __4__this;
				private UniTask<T5> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask0(UniTask<T0> task);
			private async UniTaskVoid RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask4(UniTask<T4> task);
			private async UniTaskVoid RunTask5(UniTask<T5> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6>
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private T6 result6;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask0_d__15 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T0> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask1_d__16 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2_d__17 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3_d__18 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask4_d__19 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T4> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask5_d__20 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T5> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask6_d__21 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T6> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> __4__this;
				private UniTask<T6> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask0(UniTask<T0> task);
			private async UniTaskVoid RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask4(UniTask<T4> task);
			private async UniTaskVoid RunTask5(UniTask<T5> task);
			private async UniTaskVoid RunTask6(UniTask<T6> task);
			public Awaiter GetAwaiter();
		}
	
		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7>
		{
			// Fields
			private T0 result0;
			private T1 result1;
			private T2 result2;
			private T3 result3;
			private T4 result4;
			private T5 result5;
			private T6 result6;
			private T7 result7;
			private ExceptionDispatchInfo exception;
			private Action whenComplete;
			private int completeCount;
			private int winArgumentIndex;
	
			// Properties
			private bool IsCompleted { get; }
	
			// Nested types
			public struct Awaiter : ICriticalNotifyCompletion
			{
				// Fields
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> parent;
	
				// Properties
				public bool IsCompleted { get; }
	
				// Constructors
				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> parent);
	
				// Methods
				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>> GetResult();
				public void OnCompleted(Action continuation);
				public void UnsafeOnCompleted(Action continuation);
			}
	
			[CompilerGenerated]
			private struct _RunTask0_d__16 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T0> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T0> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask1_d__17 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T1> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T1> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask2_d__18 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T2> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T2> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask3_d__19 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T3> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T3> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask4_d__20 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T4> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T4> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask5_d__21 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T5> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T5> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask6_d__22 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T6> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T6> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			[CompilerGenerated]
			private struct _RunTask7_d__23 : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncUniTaskVoidMethodBuilder __t__builder;
				public UniTask<T7> task;
				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __4__this;
				private UniTask<T7> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
	
			// Methods
			private void TryCallContinuation();
			private async UniTaskVoid RunTask0(UniTask<T0> task);
			private async UniTaskVoid RunTask1(UniTask<T1> task);
			private async UniTaskVoid RunTask2(UniTask<T2> task);
			private async UniTaskVoid RunTask3(UniTask<T3> task);
			private async UniTaskVoid RunTask4(UniTask<T4> task);
			private async UniTaskVoid RunTask5(UniTask<T5> task);
			private async UniTaskVoid RunTask6(UniTask<T6> task);
			private async UniTaskVoid RunTask7(UniTask<T7> task);
			public Awaiter GetAwaiter();
		}
	
		[CompilerGenerated]
		private struct _Run_d__42 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public bool configureAwait;
			public Action action;
			private SwitchToThreadPoolAwaitable.Awaiter __u__1;
			private object __7__wrap1;
			private int __7__wrap2;
			private YieldAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _Run_d__43 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public bool configureAwait;
			public Action<object> action;
			public object state;
			private SwitchToThreadPoolAwaitable.Awaiter __u__1;
			private object __7__wrap1;
			private int __7__wrap2;
			private YieldAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _Run_d__44<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T> __t__builder;
			public bool configureAwait;
			public Func<T> func;
			private SwitchToThreadPoolAwaitable.Awaiter __u__1;
			private object __7__wrap1;
			private int __7__wrap2;
			private T __7__wrap3;
			private YieldAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _Run_d__45<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T> __t__builder;
			public bool configureAwait;
			public Func<object, T> func;
			public object state;
			private SwitchToThreadPoolAwaitable.Awaiter __u__1;
			private object __7__wrap1;
			private int __7__wrap2;
			private T __7__wrap3;
			private YieldAwaitable.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__57<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T[]> __t__builder;
			public UniTask<T>[] tasks;
			private WhenAllPromise<T> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__58<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<T[]> __t__builder;
			public IEnumerable<UniTask<T>> tasks;
			private WhenAllPromise<T> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__59 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public UniTask[] tasks;
			private WhenAllPromise.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__60 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public IEnumerable<UniTask> tasks;
			private WhenAllPromise.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__63<T1, T2> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2>> __t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			private WhenAllPromise<T1, T2> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__64<T1, T2, T3> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3>> __t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			private WhenAllPromise<T1, T2, T3> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__65<T1, T2, T3, T4> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4>> __t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			private WhenAllPromise<T1, T2, T3, T4> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__66<T1, T2, T3, T4, T5> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5>> __t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			private WhenAllPromise<T1, T2, T3, T4, T5> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__67<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5, T6>> __t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			public UniTask<T6> task6;
			private WhenAllPromise<T1, T2, T3, T4, T5, T6> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAll_d__68<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> __t__builder;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			public UniTask<T6> task6;
			public UniTask<T7> task7;
			private WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__75<T0> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<bool, T0>> __t__builder;
			public UniTask<T0> task0;
			public UniTask task1;
			private UnitWhenAnyPromise<T0> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__76<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<int, T>> __t__builder;
			public UniTask<T>[] tasks;
			private WhenAnyPromise<T> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__77 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder<int> __t__builder;
			public UniTask[] tasks;
			private WhenAnyPromise.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__81<T0, T1> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> __t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			private WhenAnyPromise<T0, T1> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__82<T0, T1, T2> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> __t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			private WhenAnyPromise<T0, T1, T2> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__83<T0, T1, T2, T3> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> __t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			private WhenAnyPromise<T0, T1, T2, T3> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__84<T0, T1, T2, T3, T4> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> __t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			private WhenAnyPromise<T0, T1, T2, T3, T4> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__85<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> __t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			private WhenAnyPromise<T0, T1, T2, T3, T4, T5> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__86<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> __t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			public UniTask<T6> task6;
			private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _WhenAny_d__87<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			[TupleElementNames]
			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> __t__builder;
			public UniTask<T0> task0;
			public UniTask<T1> task1;
			public UniTask<T2> task2;
			public UniTask<T3> task3;
			public UniTask<T4> task4;
			public UniTask<T5> task5;
			public UniTask<T6> task6;
			public UniTask<T7> task7;
			private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal UniTask _.cctor_b__96_0();
		}
	
		// Constructors
		[DebuggerHidden]
		public UniTask(IAwaiter awaiter);
		[DebuggerHidden]
		public UniTask(Func<UniTask> factory);
		static UniTask();
	
		// Methods
		public static IEnumerator ToCoroutine(Func<UniTask> taskFactory);
		[DebuggerHidden]
		public void GetResult();
		[DebuggerHidden]
		public Awaiter GetAwaiter();
		public UniTask<bool> SuppressCancellationThrow();
		public bool Equals(UniTask other);
		public override int GetHashCode();
		public override string ToString();
		public static implicit operator UniTask<AsyncUnit>(UniTask task);
		public static YieldAwaitable Yield(PlayerLoopTiming timing = PlayerLoopTiming.Update);
		public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken);
		public static UniTask<int> DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default);
		public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default);
		public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default);
		public static UniTask FromException(Exception ex);
		public static UniTask<T> FromException<T>(Exception ex);
		public static UniTask<T> FromResult<T>(T value);
		public static UniTask FromCanceled();
		public static UniTask<T> FromCanceled<T>();
		public static UniTask FromCanceled(CancellationToken token);
		public static UniTask<T> FromCanceled<T>(CancellationToken token);
		public static UniTask<T> Lazy<T>(Func<UniTask<T>> factory);
		public static void Void(Func<UniTask> asyncAction);
		public static void Void<T>(Func<T, UniTask> asyncAction, T state);
		public static async UniTask Run(Action action, bool configureAwait = true);
		public static async UniTask Run(Action<object> action, object state, bool configureAwait = true);
		public static async UniTask<T> Run<T>(Func<T> func, bool configureAwait = true);
		public static async UniTask<T> Run<T>(Func<object, T> func, object state, bool configureAwait = true);
		public static SwitchToMainThreadAwaitable SwitchToMainThread();
		public static SwitchToThreadPoolAwaitable SwitchToThreadPool();
		public static SwitchToTaskPoolAwaitable SwitchToTaskPool();
		public static SwitchToSynchronizationContextAwaitable SwitchToSynchronizationContext(SynchronizationContext syncContext);
		public static UniTask WaitUntil(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default);
		public static UniTask WaitWhile(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default);
		public static UniTask<U> WaitUntilValueChanged<T, U>(T target, Func<T, U> monitorFunction, PlayerLoopTiming monitorTiming = PlayerLoopTiming.Update, IEqualityComparer<U> equalityComparer = null, CancellationToken cancellationToken = default)
			where T : class;
		public static async UniTask<T[]> WhenAll<T>(params UniTask<T>[] tasks);
		public static async UniTask<T[]> WhenAll<T>(IEnumerable<UniTask<T>> tasks);
		public static async UniTask WhenAll(params UniTask[] tasks);
		public static async UniTask WhenAll(IEnumerable<UniTask> tasks);
		public static async UniTask<ValueTuple<T1, T2>> WhenAll<T1, T2>(UniTask<T1> task1, UniTask<T2> task2);
		public static async UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
		public static async UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
		public static async UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
		public static async UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
		public static async UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
		public static async UniTask<ValueTuple<bool, T0>> WhenAny<T0>(UniTask<T0> task0, UniTask task1);
		public static async UniTask<ValueTuple<int, T>> WhenAny<T>(params UniTask<T>[] tasks);
		public static async UniTask<int> WhenAny(params UniTask[] tasks);
		public static async UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> WhenAny<T0, T1>(UniTask<T0> task0, UniTask<T1> task1);
		public static async UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> WhenAny<T0, T1, T2>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2);
		public static async UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> WhenAny<T0, T1, T2, T3>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3);
		public static async UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> WhenAny<T0, T1, T2, T3, T4>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4);
		public static async UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> WhenAny<T0, T1, T2, T3, T4, T5>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5);
		public static async UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6);
		public static async UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6, T7>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7);
	}
}
