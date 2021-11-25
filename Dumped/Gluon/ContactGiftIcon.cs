using System;
using System.Collections;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactGiftIcon : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private GameObject checkImage;

		[SerializeField]
		private Text selectCountText;

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

		public int dragonGiftId => default(int);

		private void OnDisable()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void ApiBuyGiftToSend()
		{
		}

		public void ApiOnBuyGiftToSendError(ErrorType errorType, int errorCode)
		{
		}

		private void ApiOnBuyGiftToSendSuccess(DragonBuyGiftToSendResponse res)
		{
		}

		public void ApiSendGift()
		{
		}

		public void ApiOnSendGiftError(ErrorType errorType, int errorCode)
		{
		}

		private void ApiOnSendGiftSuccess(DragonSendGiftResponse res)
		{
		}

		public void ApiWalkerSendGift()
		{
		}

		public void ApiOnSendWalkerGiftError(ErrorType errorType, int errorCode)
		{
		}

		private void ApiOnSendWalkerGiftSuccess(WalkerSendGiftMultipleResponse res)
		{
		}

		public void DoConsumeItemAnimationInStrokeMainWithDelay(Action onComplete, float delayTime)
		{
		}

		private IEnumerator DoConsumeItemAnimationInStrokeMainWithDelayCoroutine(Action onComplete, float delayTime)
		{
			return null;
		}

		public void DoConsumeItemAnimationInStrokeMain(Action onComplete)
		{
		}

		public void DoConsumeItemAnimation(Action onComplete)
		{
		}

		public void SetupByItemId(int itemId, int price, bool isShop, bool soldOut)
		{
		}

		public void SetupBySimpleEventItemId(int itemId, int num)
		{
		}

		public void SetIconColor(long RemainingCoin)
		{
		}

		public void OnClick()
		{
		}

		public void OnSelected(bool byUI = false)
		{
		}

		private void SetHoldingItemIcon()
		{
		}

		private DragonGiftList GetDragonGiftData()
		{
			return null;
		}

		public void OnSelectedNoneInteractive(bool byUI = false)
		{
		}

		public void OnDeselected()
		{
		}

		public void OnHolding()
		{
		}

		public void OnReleaseHolding()
		{
		}

		public void Release()
		{
		}

		public void SetSelectImage(int num)
		{
		}

		public void HideSelextImage()
		{
		}

		private void SetSelected(bool selected)
		{
		}
	}
}
