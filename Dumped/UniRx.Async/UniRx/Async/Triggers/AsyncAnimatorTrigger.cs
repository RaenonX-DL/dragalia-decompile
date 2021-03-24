/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncAnimatorTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<int> onAnimatorIK;
		private AsyncTriggerPromiseDictionary<int> onAnimatorIKs;
		private AsyncTriggerPromise<AsyncUnit> onAnimatorMove;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onAnimatorMoves;
	
		// Constructors
		public AsyncAnimatorTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnAnimatorIK(int layerIndex);
		public UniTask<int> OnAnimatorIKAsync(CancellationToken cancellationToken = default);
		private void OnAnimatorMove();
		public UniTask OnAnimatorMoveAsync(CancellationToken cancellationToken = default);
	}
}
