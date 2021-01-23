/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal sealed class AsyncSubject<T> : IObservable<T>, IObserver<T>
	{
		// Fields
		private object observerLock;
		private T lastValue;
		private bool hasValue;
		private bool isStopped;
		private bool isDisposed;
		private Exception lastError;
		private IObserver<T> outObserver;
	
		// Properties
		public T Value { get; }
		public bool HasObservers { get; }
		public bool IsCompleted { get; }
	
		// Nested types
		private class Subscription : IDisposable
		{
			// Fields
			private readonly object gate;
			private AsyncSubject<T> parent;
			private IObserver<T> unsubscribeTarget;
	
			// Constructors
			public Subscription(AsyncSubject<T> parent, IObserver<T> unsubscribeTarget);
	
			// Methods
			public void Dispose();
		}
	
		// Constructors
		public AsyncSubject();
	
		// Methods
		public void OnCompleted();
		public void OnError(Exception error);
		public void OnNext(T value);
		public IDisposable Subscribe(IObserver<T> observer);
		public void Dispose();
		private void ThrowIfDisposed();
	}
}
