/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal sealed class LazyPromise<T> : IAwaiter<T>
	{
		// Fields
		private Func<UniTask<T>> factory;
		private UniTask<T> value;
	
		// Properties
		public bool IsCompleted { get; }
		public AwaiterStatus Status { get; }
	
		// Constructors
		public LazyPromise(Func<UniTask<T>> factory);
	
		// Methods
		private void Create();
		public T GetResult();
		void IAwaiter.GetResult();
		public void UnsafeOnCompleted(Action continuation);
		public void OnCompleted(Action continuation);
	}
}
