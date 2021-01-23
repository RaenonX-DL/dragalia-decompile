/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	[AsyncMethodBuilder]
	public struct UniTask<T> : IEquatable<UniRx.Async.UniTask<T>>
	{
		// Fields
		private readonly T result;
		private readonly IAwaiter<T> awaiter;
	
		// Properties
		[DebuggerHidden]
		public AwaiterStatus Status { get; }
		[DebuggerHidden]
		public bool IsCompleted { get; }
		[DebuggerHidden]
		public T Result { get; }
	
		// Nested types
		private class IsCanceledAwaiter : IAwaiter<ValueTuple<bool, T>>
		{
			// Fields
			private readonly IAwaiter<T> awaiter;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public IsCanceledAwaiter(IAwaiter<T> awaiter);
	
			// Methods
			public ValueTuple<bool, T> GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
			void IAwaiter.GetResult();
		}
	
		public struct Awaiter : IAwaiter<T>
		{
			// Fields
			private readonly UniTask<T> task;
	
			// Properties
			[DebuggerHidden]
			public bool IsCompleted { get; }
			[DebuggerHidden]
			public AwaiterStatus Status { get; }
	
			// Constructors
			[DebuggerHidden]
			public Awaiter(UniTask<T> task);
	
			// Methods
			[DebuggerHidden]
			void IAwaiter.GetResult();
			[DebuggerHidden]
			public T GetResult();
			[DebuggerHidden]
			public void OnCompleted(Action continuation);
			[DebuggerHidden]
			public void UnsafeOnCompleted(Action continuation);
		}
	
		// Constructors
		[DebuggerHidden]
		public UniTask(T result);
		[DebuggerHidden]
		public UniTask(IAwaiter<T> awaiter);
		[DebuggerHidden]
		public UniTask(Func<UniTask<T>> factory);
	
		// Methods
		[DebuggerHidden]
		public Awaiter GetAwaiter();
		public UniTask<ValueTuple<bool, T>> SuppressCancellationThrow();
		public bool Equals(UniTask<T> other);
		public override int GetHashCode();
		public override string ToString();
		public static implicit operator UniTask(UniTask<T> task);
	}
}
