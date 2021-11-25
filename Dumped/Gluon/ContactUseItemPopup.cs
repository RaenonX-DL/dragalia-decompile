using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactUseItemPopup : PopupBase
	{
		[SerializeField]
		private CommonIcon beforeIcon;

		[SerializeField]
		private CommonIcon afterIcon;

		[SerializeField]
		private CommonIcon itemIcon;

		[SerializeField]
		private Text itemName;

		[SerializeField]
		private Text ItemDescription;

		[SerializeField]
		private CommonSliderSelection slider;

		[SerializeField]
		private Text overText;

		[SerializeField]
		private float delayTimeIcon;

		[SerializeField]
		private float delayTimeShopPanel;

		private DragonStrokeMain dragonStrokeMain;

		private ContactGiftIcon targetIcon;

		private int currentLevel;

		private int afterLevel;

		private int maxLevel;

		private int currentValue;

		private int overValue;

		private int reliability;

		private int presentItemNum;

		private int dragonId;

		private const int presentItemMaxValue = 30;

		private bool isEalkerEventItem;

		public static ContactUseItemPopup Create(UnityAction onClose, bool isEalkerEventItem)
		{
			return null;
		}

		public void Setup(DragonStrokeMain dragonStroke, DragonGiftList dragonGift, ContactGiftIcon icon, bool isWalkEventItem)
		{
		}

		private void OnSlideValueChanged(float value)
		{
		}

		public void OnPressOk()
		{
		}

		private void SendPresent()
		{
		}

		public void ApiSendGiftMultiple()
		{
		}

		public void ApiOnSendGiftMultipleError(ErrorType errorType, int errorCode)
		{
		}

		private void ApiOnSendGiftMultipleSuccess(DragonSendGiftMultipleResponse res)
		{
		}

		public void ApiSendWalkerGiftMultiple()
		{
		}

		public void ApiOnSendWalkerGiftMultipleError(ErrorType errorType, int errorCode)
		{
		}

		private void ApiOnSendWalkerGiftMultipleSuccess(WalkerSendGiftMultipleResponse res)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
