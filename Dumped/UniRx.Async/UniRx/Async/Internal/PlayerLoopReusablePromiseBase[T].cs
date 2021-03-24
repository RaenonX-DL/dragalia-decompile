/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	public abstract class PlayerLoopReusablePromiseBase<T> : ReusablePromise<T>, IPlayerLoopItem
	{
		// Fields
		private readonly PlayerLoopTiming timing;
		protected readonly CancellationToken cancellationToken;
		private bool isRunning;
	
		// Properties
		public override bool IsCompleted { get; }
	
		// Constructors
		public PlayerLoopReusablePromiseBase(PlayerLoopTiming timing, CancellationToken cancellationToken, int skipTrackFrameCountAdditive);
	
		// Methods
		protected abstract void OnRunningStart();
		protected void Complete();
		public abstract bool MoveNext();
	}
}
