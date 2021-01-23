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
	public class AsyncEventTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onDeselect;
		private AsyncTriggerPromiseDictionary<BaseEventData> onDeselects;
		private AsyncTriggerPromise<AxisEventData> onMove;
		private AsyncTriggerPromiseDictionary<AxisEventData> onMoves;
		private AsyncTriggerPromise<PointerEventData> onPointerDown;
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerDowns;
		private AsyncTriggerPromise<PointerEventData> onPointerEnter;
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters;
		private AsyncTriggerPromise<PointerEventData> onPointerExit;
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerExits;
		private AsyncTriggerPromise<PointerEventData> onPointerUp;
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerUps;
		private AsyncTriggerPromise<BaseEventData> onSelect;
		private AsyncTriggerPromiseDictionary<BaseEventData> onSelects;
		private AsyncTriggerPromise<PointerEventData> onPointerClick;
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerClicks;
		private AsyncTriggerPromise<BaseEventData> onSubmit;
		private AsyncTriggerPromiseDictionary<BaseEventData> onSubmits;
		private AsyncTriggerPromise<PointerEventData> onDrag;
		private AsyncTriggerPromiseDictionary<PointerEventData> onDrags;
		private AsyncTriggerPromise<PointerEventData> onBeginDrag;
		private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags;
		private AsyncTriggerPromise<PointerEventData> onEndDrag;
		private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags;
		private AsyncTriggerPromise<PointerEventData> onDrop;
		private AsyncTriggerPromiseDictionary<PointerEventData> onDrops;
		private AsyncTriggerPromise<BaseEventData> onUpdateSelected;
		private AsyncTriggerPromiseDictionary<BaseEventData> onUpdateSelecteds;
		private AsyncTriggerPromise<PointerEventData> onInitializePotentialDrag;
		private AsyncTriggerPromiseDictionary<PointerEventData> onInitializePotentialDrags;
		private AsyncTriggerPromise<BaseEventData> onCancel;
		private AsyncTriggerPromiseDictionary<BaseEventData> onCancels;
		private AsyncTriggerPromise<PointerEventData> onScroll;
		private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls;
	
		// Constructors
		public AsyncEventTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnDeselect(BaseEventData eventData);
		public UniTask<BaseEventData> OnDeselectAsync(CancellationToken cancellationToken = default);
		private void OnMove(AxisEventData eventData);
		public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken = default);
		private void OnPointerDown(PointerEventData eventData);
		public UniTask<PointerEventData> OnPointerDownAsync(CancellationToken cancellationToken = default);
		private void OnPointerEnter(PointerEventData eventData);
		public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken = default);
		private void OnPointerExit(PointerEventData eventData);
		public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken = default);
		private void OnPointerUp(PointerEventData eventData);
		public UniTask<PointerEventData> OnPointerUpAsync(CancellationToken cancellationToken = default);
		private void OnSelect(BaseEventData eventData);
		public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken = default);
		private void OnPointerClick(PointerEventData eventData);
		public UniTask<PointerEventData> OnPointerClickAsync(CancellationToken cancellationToken = default);
		private void OnSubmit(BaseEventData eventData);
		public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken = default);
		private void OnDrag(PointerEventData eventData);
		public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken = default);
		private void OnBeginDrag(PointerEventData eventData);
		public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken = default);
		private void OnEndDrag(PointerEventData eventData);
		public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken = default);
		private void OnDrop(PointerEventData eventData);
		public UniTask<PointerEventData> OnDropAsync(CancellationToken cancellationToken = default);
		private void OnUpdateSelected(BaseEventData eventData);
		public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken = default);
		private void OnInitializePotentialDrag(PointerEventData eventData);
		public UniTask<PointerEventData> OnInitializePotentialDragAsync(CancellationToken cancellationToken = default);
		private void OnCancel(BaseEventData eventData);
		public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken = default);
		private void OnScroll(PointerEventData eventData);
		public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken = default);
	}
}
