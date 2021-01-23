/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactGiftIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private GameObject checkImage;
		[SerializeField]
		private UnityEngine.UI.Text selectCountText;
		[SerializeField]
		private GameObject selectedDragIndicator;
		[SerializeField]
		private GameObject soldOutNode;
		[SerializeField]
		private Button invalidButton;
		[SerializeField]
		private Image holdingItem;
		[SerializeField]
		private GameObject CoinImage;
		[SerializeField]
		private GameObject NoteImage;
		[SerializeField]
		private GameObject shopIconTextBack;
		[SerializeField]
		private GameObject giftIconTextBack;
		private bool holding;
		private const float consumeItemAnimationTime = 0.8f;
		private const float consumeItemJumpHeight = 120f;
		[HideInInspector]
		public ContactShopPanel shopPanel;
		private bool isShop;
		private bool isDragging;
		private bool isSelected;
		private bool isFirstHidingShopPanel;
		[HideInInspector]
		public int price;
		private int reliability;
		private bool soldOut;
		private static Vector2 giftIconTextPos;
		private Transform defaultParent;
		private PointerEventData currentEventData;
		[HideInInspector]
		public bool isWalkEventItem;
	
		// Properties
		public int dragonGiftId { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public ContactGiftIcon __4__this;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _OnEndDrag_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _DoConsumeItemAnimationInStrokeMainWithDelayCoroutine_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delayTime;
			public ContactGiftIcon __4__this;
			public Action onComplete;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DoConsumeItemAnimationInStrokeMainWithDelayCoroutine_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public Action onComplete;
			public ContactGiftIcon __4__this;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _DoConsumeItemAnimationInStrokeMain_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public ContactGiftIcon __4__this;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _DoConsumeItemAnimation_b__0();
		}
	
		// Constructors
		public ContactGiftIcon();
		static ContactGiftIcon();
	
		// Methods
		private void OnDisable();
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		private void OnApplicationPause(bool pause);
		public void OnEndDrag(PointerEventData eventData);
		public void ApiBuyGiftToSend();
		public void ApiOnBuyGiftToSendError(ErrorType errorType, int errorCode);
		private void ApiOnBuyGiftToSendSuccess(DragonBuyGiftToSendResponse res);
		public void ApiSendGift();
		public void ApiOnSendGiftError(ErrorType errorType, int errorCode);
		private void ApiOnSendGiftSuccess(DragonSendGiftResponse res);
		public void ApiWalkerSendGift();
		public void ApiOnSendWalkerGiftError(ErrorType errorType, int errorCode);
		private void ApiOnSendWalkerGiftSuccess(WalkerSendGiftMultipleResponse res);
		public void DoConsumeItemAnimationInStrokeMainWithDelay(Action onComplete, float delayTime);
		[IteratorStateMachine]
		private IEnumerator DoConsumeItemAnimationInStrokeMainWithDelayCoroutine(Action onComplete, float delayTime);
		public void DoConsumeItemAnimationInStrokeMain(Action onComplete);
		public void DoConsumeItemAnimation(Action onComplete);
		public void SetupByItemId(int itemId, int price, bool isShop, bool soldOut);
		public void SetupBySimpleEventItemId(int itemId, int num);
		public void SetIconColor(long RemainingCoin);
		public void OnClick();
		public void OnSelected(bool byUI = false);
		private void SetHoldingItemIcon();
		private DragonGiftList GetDragonGihtData();
		public void OnSelectedNoneInteractive(bool byUI = false);
		public void OnDeselected();
		public void OnHolding();
		public void OnReleaseHolding();
		public void Release();
		public void SetSelectImage(int num);
		public void HideSelextImage();
		private void SetSelected(bool selected);
		[CompilerGenerated]
		private bool _GetDragonGihtData_b__52_0(DragonGiftList x);
	}
}
