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
	public class AsyncTransformChangedTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onBeforeTransformParentChanged;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBeforeTransformParentChangeds;
		private AsyncTriggerPromise<AsyncUnit> onTransformParentChanged;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformParentChangeds;
		private AsyncTriggerPromise<AsyncUnit> onTransformChildrenChanged;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformChildrenChangeds;
	
		// Constructors
		public AsyncTransformChangedTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnBeforeTransformParentChanged();
		public UniTask OnBeforeTransformParentChangedAsync(CancellationToken cancellationToken = default);
		private void OnTransformParentChanged();
		public UniTask OnTransformParentChangedAsync(CancellationToken cancellationToken = default);
		private void OnTransformChildrenChanged();
		public UniTask OnTransformChildrenChangedAsync(CancellationToken cancellationToken = default);
	}
}
