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
	public class AsyncCanvasGroupChangedTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onCanvasGroupChanged;
		private AsyncTriggerPromiseDictionary<AsyncUnit> onCanvasGroupChangeds;
	
		// Constructors
		public AsyncCanvasGroupChangedTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnCanvasGroupChanged();
		public UniTask OnCanvasGroupChangedAsync(CancellationToken cancellationToken = default);
	}
}
