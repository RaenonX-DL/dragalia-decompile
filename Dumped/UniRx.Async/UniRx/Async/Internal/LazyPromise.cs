/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal sealed class LazyPromise : IAwaiter
	{
		// Fields
		private Func<UniTask> factory;
		private UniTask value;
	
		// Properties
		public bool IsCompleted { get; }
		public AwaiterStatus Status { get; }
	
		// Constructors
		public LazyPromise(Func<UniTask> factory);
	
		// Methods
		private void Create();
		public void GetResult();
		void IAwaiter.GetResult();
		public void UnsafeOnCompleted(Action continuation);
		public void OnCompleted(Action continuation);
	}
}
