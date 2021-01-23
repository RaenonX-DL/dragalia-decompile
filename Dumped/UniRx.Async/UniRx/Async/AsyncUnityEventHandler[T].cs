/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Events;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public class AsyncUnityEventHandler<T> : IAwaiter<T>, IAsyncValueChangedEventHandler<T>, IAsyncEndEditEventHandler<T>
	{
		// Fields
		private static Action<object> cancellationCallback;
		private readonly UnityAction<T> action;
		private readonly UnityEvent<T> unityEvent;
		private Action continuation;
		private CancellationTokenRegistration registration;
		private bool isDisposed;
		private T eventValue;
		private bool callOnce;
		private UniTask<ValueTuple<bool, T>>? suppressCancellationThrowTask;
	
		// Properties
		bool IAwaiter.IsCompleted { get; }
		AwaiterStatus IAwaiter.Status { get; }
	
		// Constructors
		public AsyncUnityEventHandler(UnityEvent<T> unityEvent, CancellationToken cancellationToken, bool callOnce);
		static AsyncUnityEventHandler();
	
		// Methods
		public UniTask<T> OnInvokeAsync();
		public UniTask<ValueTuple<bool, T>> OnInvokeAsyncSuppressCancellationThrow();
		private void Invoke(T value);
		private static void CancellationCallback(object state);
		public void Dispose();
		T IAwaiter<T>.GetResult();
		void IAwaiter.GetResult();
		void INotifyCompletion.OnCompleted(Action action);
		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action);
		UniTask<T> IAsyncValueChangedEventHandler<T>.OnValueChangedAsync();
		UniTask<ValueTuple<bool, T>> IAsyncValueChangedEventHandler<T>.OnValueChangedAsyncSuppressCancellationThrow();
		UniTask<T> IAsyncEndEditEventHandler<T>.OnEndEditAsync();
		UniTask<ValueTuple<bool, T>> IAsyncEndEditEventHandler<T>.OnEndEditAsyncSuppressCancellationThrow();
	}
}
