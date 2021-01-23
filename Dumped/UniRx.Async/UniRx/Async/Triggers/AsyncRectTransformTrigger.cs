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

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncRectTransformTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onRectTransformDimensionsChange;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformDimensionsChanges;
		private AsyncTriggerPromise<AsyncUnit> onRectTransformRemoved;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformRemoveds;
	
		// Constructors
		public AsyncRectTransformTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnRectTransformDimensionsChange();
		public UniTask OnRectTransformDimensionsChangeAsync(CancellationToken cancellationToken = default);
		private void OnRectTransformRemoved();
		public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken = default);
	}
}
