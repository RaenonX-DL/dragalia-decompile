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
	internal sealed class PlayerLoopRunner
	{
		// Fields
		private const int InitialSize = 16;
		private readonly object runningAndQueueLock;
		private readonly object arrayLock;
		private readonly Action<Exception> unhandledExceptionCallback;
		private int tail;
		private bool running;
		private IPlayerLoopItem[] loopItems;
		private MinimumQueue<IPlayerLoopItem> waitQueue;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<Exception> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _.ctor_b__8_0(Exception ex);
		}
	
		// Constructors
		public PlayerLoopRunner();
	
		// Methods
		public void AddAction(IPlayerLoopItem item);
		public void Run();
	}
}
