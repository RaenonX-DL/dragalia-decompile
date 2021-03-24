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
using UnityEngine.EventSystems;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncCancelTrigger : AsyncTriggerBase, ICancelHandler
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onCancel;
		private AsyncTriggerPromiseDictionary<BaseEventData> onCancels;
	
		// Constructors
		public AsyncCancelTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		void ICancelHandler.OnCancel(BaseEventData eventData);
		public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken = default);
	}
}
