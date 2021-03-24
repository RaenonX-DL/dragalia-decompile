/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Events;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public class AsyncUnityEventHandler : IAwaiter, IAsyncClickEventHandler
	{
		// Fields
		private static Action<object> cancellationCallback;
		private readonly UnityAction action;
		private readonly UnityEvent unityEvent;
		private Action continuation;
		private CancellationTokenRegistration registration;
		private bool isDisposed;
		private bool callOnce;
		private UniTask<bool>? suppressCancellationThrowTask;
	
		// Properties
		bool IAwaiter.IsCompleted { get; }
		AwaiterStatus IAwaiter.Status { get; }
	
		// Constructors
		public AsyncUnityEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken, bool callOnce);
		static AsyncUnityEventHandler();
	
		// Methods
		public UniTask OnInvokeAsync();
		public UniTask<bool> OnInvokeAsyncSuppressCancellationThrow();
		private void Invoke();
		private static void CancellationCallback(object state);
		public void Dispose();
		void IAwaiter.GetResult();
		void INotifyCompletion.OnCompleted(Action action);
		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action);
		UniTask IAsyncClickEventHandler.OnClickAsync();
		UniTask<bool> IAsyncClickEventHandler.OnClickAsyncSuppressCancellationThrow();
	}
}
