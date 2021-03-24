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
	public class AsyncLateUpdateTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> lateUpdate;
		private AsyncTriggerPromiseDictionary<AsyncUnit> lateUpdates;
	
		// Constructors
		public AsyncLateUpdateTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void LateUpdate();
		public UniTask LateUpdateAsync(CancellationToken cancellationToken = default);
	}
}
