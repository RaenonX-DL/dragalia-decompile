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
	public class AsyncPointerEnterTrigger : AsyncTriggerBase, IPointerEnterHandler
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerEnter;
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters;
	
		// Constructors
		public AsyncPointerEnterTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData);
		public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken = default);
	}
}
