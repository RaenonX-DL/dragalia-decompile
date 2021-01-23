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

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncEndDragTrigger : AsyncTriggerBase, IEndDragHandler
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onEndDrag;
		private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags;
	
		// Constructors
		public AsyncEndDragTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		void IEndDragHandler.OnEndDrag(PointerEventData eventData);
		public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken = default);
	}
}
