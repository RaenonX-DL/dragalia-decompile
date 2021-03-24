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
	public class AsyncVisibleTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onBecameInvisible;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameInvisibles;
		private AsyncTriggerPromise<AsyncUnit> onBecameVisible;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameVisibles;
	
		// Constructors
		public AsyncVisibleTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnBecameInvisible();
		public UniTask OnBecameInvisibleAsync(CancellationToken cancellationToken = default);
		private void OnBecameVisible();
		public UniTask OnBecameVisibleAsync(CancellationToken cancellationToken = default);
	}
}
