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
	public class AsyncBeginDragTrigger : AsyncTriggerBase, IBeginDragHandler
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onBeginDrag;
		private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags;
	
		// Constructors
		public AsyncBeginDragTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData);
		public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken = default);
	}
}
