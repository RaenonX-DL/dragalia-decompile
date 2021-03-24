/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.Internal;
using UnityEngine;
using UnityEngine.Experimental.LowLevel;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class PlayerLoopHelper
	{
		// Fields
		private static int mainThreadId;
		private static SynchronizationContext unitySynchronizationContetext;
		private static ContinuationQueue[] yielders;
		private static PlayerLoopRunner[] runners;
	
		// Properties
		public static SynchronizationContext UnitySynchronizationContext { get; }
		public static int MainThreadId { get; }
	
		// Methods
		private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner);
		[RuntimeInitializeOnLoadMethod]
		private static void Init();
		public static void Initialize(ref PlayerLoopSystem playerLoop);
		public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action);
		public static void AddContinuation(PlayerLoopTiming timing, Action continuation);
	}
}
