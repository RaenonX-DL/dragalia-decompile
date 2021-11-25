using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TradeItemDonePopup : ShopCommonPopup
	{
		[SerializeField]
		[Header("Contents")]
		public Text itemName;

		public CommonIcon icon;

		public Text ownedCount;

		public Text sentToPresentBoxText;

		[SerializeField]
		[Header("OnOffs")]
		public Text singleExchangedText;

		public Text multiExchangedText;

		public GameObject ownedCountParent;

		[SerializeField]
		private List<GameObject> rarityObjs;

		private Action onPopupClosed;

		public static TradeItemDonePopup Create(ShopTradeProductData.TradeShopItemData data, int tradedCount, Action onPopupClosed)
		{
			return null;
		}

		public static TradeItemDonePopup Create(string itemName, GiftType giftType, int itemId, int limitBreak, int bunchCount, bool sentToPresentBox, int tradedCount, Action onPopupClosed)
		{
			return null;
		}

		private void Init(string itemName, GiftType giftType, int itemId, int limitBreak, int bunchCount, bool sentToPresentBox, int tradedCount)
		{
		}
	}
}
