/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public struct SwitchToSynchronizationContextAwaitable
	{
		// Fields
		private readonly SynchronizationContext synchronizationContext;
	
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion
		{
			// Fields
			private static readonly SendOrPostCallback switchToCallback;
			private readonly SynchronizationContext synchronizationContext;
	
			// Properties
			public bool IsCompleted { get; }
	
			// Constructors
			public Awaiter(SynchronizationContext synchronizationContext);
			static Awaiter();
	
			// Methods
			public void GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
			private static void Callback(object state);
		}
	
		// Constructors
		public SwitchToSynchronizationContextAwaitable(SynchronizationContext synchronizationContext);
	
		// Methods
		public Awaiter GetAwaiter();
	}
}
