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
	public struct UniTaskVoid
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion
		{
			// Properties
			[DebuggerHidden]
			public bool IsCompleted { get; }
	
			// Methods
			[DebuggerHidden]
			public void GetResult();
			[DebuggerHidden]
			public void OnCompleted(Action continuation);
			[DebuggerHidden]
			public void UnsafeOnCompleted(Action continuation);
		}
	
		// Methods
		public void Forget();
		[DebuggerHidden]
		public Awaiter GetAwaiter();
	}
}
