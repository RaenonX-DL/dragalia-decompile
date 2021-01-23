/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public struct YieldAwaitable
	{
		// Fields
		private readonly PlayerLoopTiming timing;
	
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion
		{
			// Fields
			private readonly PlayerLoopTiming timing;
	
			// Properties
			public bool IsCompleted { get; }
	
			// Constructors
			public Awaiter(PlayerLoopTiming timing);
	
			// Methods
			public void GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		// Constructors
		public YieldAwaitable(PlayerLoopTiming timing);
	
		// Methods
		public Awaiter GetAwaiter();
		public UniTask ToUniTask();
	}
}
