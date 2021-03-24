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
	public class AsyncScrollTrigger : AsyncTriggerBase, IScrollHandler
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onScroll;
		private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls;
	
		// Constructors
		public AsyncScrollTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		void IScrollHandler.OnScroll(PointerEventData eventData);
		public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken = default);
	}
}
