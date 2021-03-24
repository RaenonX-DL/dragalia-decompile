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
	public class AsyncUpdateTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> update;
		private AsyncTriggerPromiseDictionary<AsyncUnit> updates;
	
		// Constructors
		public AsyncUpdateTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void Update();
		public UniTask UpdateAsync(CancellationToken cancellationToken = default);
	}
}
