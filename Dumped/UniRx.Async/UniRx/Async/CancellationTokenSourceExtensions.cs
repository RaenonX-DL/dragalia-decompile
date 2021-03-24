/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.CompilerServices;
using UnityEngine;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class CancellationTokenSourceExtensions
	{
		// Nested types
		[CompilerGenerated]
		private struct _CancelAfterCore_d__2 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskVoidMethodBuilder __t__builder;
			public UniTask delayTask;
			public CancellationTokenSource cts;
			private UniTask<bool> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Methods
		private static async UniTaskVoid CancelAfterCore(CancellationTokenSource cts, UniTask delayTask);
	
		// Extension methods
		public static void CancelAfterSlim(this CancellationTokenSource cts, int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update);
		public static void CancelAfterSlim(this CancellationTokenSource cts, TimeSpan delayTimeSpan, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update);
		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, Component component);
		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, GameObject gameObject);
	}
}
