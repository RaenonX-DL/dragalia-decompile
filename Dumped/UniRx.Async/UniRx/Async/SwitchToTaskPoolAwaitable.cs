/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public struct SwitchToTaskPoolAwaitable
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion
		{
			// Fields
			private static readonly Action<object> switchToCallback;
	
			// Properties
			public bool IsCompleted { get; }
	
			// Constructors
			static Awaiter();
	
			// Methods
			public void GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
			private static void Callback(object state);
		}
	
		// Methods
		public Awaiter GetAwaiter();
	}
}
