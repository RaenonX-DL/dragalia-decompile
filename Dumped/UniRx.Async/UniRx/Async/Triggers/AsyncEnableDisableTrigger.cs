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
	public class AsyncEnableDisableTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onEnable;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onEnables;
		private AsyncTriggerPromise<AsyncUnit> onDisable;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onDisables;
	
		// Constructors
		public AsyncEnableDisableTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnEnable();
		public UniTask OnEnableAsync(CancellationToken cancellationToken = default);
		private void OnDisable();
		public UniTask OnDisableAsync(CancellationToken cancellationToken = default);
	}
}
