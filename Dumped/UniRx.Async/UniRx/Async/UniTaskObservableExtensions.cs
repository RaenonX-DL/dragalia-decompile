/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.CompilerServices;
using UniRx.Async.Internal;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class UniTaskObservableExtensions
	{
		// Nested types
		private class ToUniTaskObserver<T> : IObserver<T>
		{
			// Fields
			private static readonly Action<object> callback;
			private readonly UniTaskCompletionSource<T> promise;
			private readonly SingleAssignmentDisposable disposable;
			private readonly CancellationToken cancellationToken;
			private readonly CancellationTokenRegistration registration;
			private bool hasValue;
			private T latestValue;
	
			// Constructors
			public ToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken);
			static ToUniTaskObserver();
	
			// Methods
			private static void OnCanceled(object state);
			public void OnNext(T value);
			public void OnError(Exception error);
			public void OnCompleted();
		}
	
		private class FirstValueToUniTaskObserver<T> : IObserver<T>
		{
			// Fields
			private static readonly Action<object> callback;
			private readonly UniTaskCompletionSource<T> promise;
			private readonly SingleAssignmentDisposable disposable;
			private readonly CancellationToken cancellationToken;
			private readonly CancellationTokenRegistration registration;
			private bool hasValue;
	
			// Constructors
			public FirstValueToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken);
			static FirstValueToUniTaskObserver();
	
			// Methods
			private static void OnCanceled(object state);
			public void OnNext(T value);
			public void OnError(Exception error);
			public void OnCompleted();
		}
	
		private class ReturnObservable<T> : IObservable<T>
		{
			// Fields
			private readonly T value;
	
			// Constructors
			public ReturnObservable(T value);
	
			// Methods
			public IDisposable Subscribe(IObserver<T> observer);
		}
	
		private class ThrowObservable<T> : IObservable<T>
		{
			// Fields
			private readonly Exception value;
	
			// Constructors
			public ThrowObservable(Exception value);
	
			// Methods
			public IDisposable Subscribe(IObserver<T> observer);
		}
	
		[CompilerGenerated]
		private struct _Fire_d__3<T> : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskVoidMethodBuilder __t__builder;
			public UniTask<T> task;
			public AsyncSubject<T> subject;
			private UniTask<T> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _Fire_d__4 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskVoidMethodBuilder __t__builder;
			public UniTask task;
			public AsyncSubject<object> subject;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Methods
		private static async UniTaskVoid Fire<T>(AsyncSubject<T> subject, UniTask<T> task);
		private static async UniTaskVoid Fire(AsyncSubject<object> subject, UniTask task);
	
		// Extension methods
		public static UniTask<T> ToUniTask<T>(this IObservable<T> source, CancellationToken cancellationToken = default, bool useFirstValue = false);
		public static IObservable<T> ToObservable<T>(this UniTask<T> task);
		public static IObservable<AsyncUnit> ToObservable(this UniTask task);
	}
}
