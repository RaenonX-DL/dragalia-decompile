/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using UniRx.Async;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	public abstract class ReusablePromise : IAwaiter
	{
		// Fields
		private ExceptionDispatchInfo exception;
		private object continuation;
		private AwaiterStatus status;
	
		// Properties
		public UniTask Task { get; }
		public virtual bool IsCompleted { get; }
		public AwaiterStatus Status { get; }
	
		// Constructors
		protected ReusablePromise();
	
		// Methods
		public virtual void GetResult();
		void IAwaiter.GetResult();
		public void ResetStatus(bool forceReset);
		public virtual bool TrySetCanceled();
		public virtual bool TrySetException(Exception ex);
		public virtual bool TrySetResult();
		private void TryInvokeContinuation();
		public void OnCompleted(Action action);
		public void UnsafeOnCompleted(Action action);
	}
}
