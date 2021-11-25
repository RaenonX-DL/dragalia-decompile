using System;
using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TradeMaterialItemConfirmPopup : ShopCommonPopup, ICustomMessage
	{
		protected ShopTradeProductData.TradeShopItemData data;

		protected Action onPopupClosed;

		public Action onPopupCancelled;

		[SerializeField]
		[Header("Contents")]
		public Text itemName;

		public Text itemDescription;

		public CommonIcon icon;

		public Text ownedCount;

		public CommonSliderSelection slider;

		public Text priceText;

		public Text confirmText;

		public GameObject sliderFrame;

		public Button tradeButton;

		[SerializeField]
		private Text itemNoticeText;

		[SerializeField]
		[Header("Materials")]
		public ShopTradeMaterialIcon[] materialIcons;

		[SerializeField]
		[Header("Selection")]
		public SelectIconListController selectController;

		[SerializeField]
		[Header("OnOffs")]
		public GameObject ownedCountParent;

		[SerializeField]
		private List<GameObject> rarityObjs;

		[SerializeField]
		protected Text selectAmuletText;

		[SerializeField]
		[Header("Limit")]
		public Text limitCountText;

		public Text endTimeText;

		public Text limitCommentText;

		public bool isUseShortQuantityLimite;

		[SerializeField]
		[Header("Abirity Crest")]
		private Text errorText;

		protected int tradeCount;

		protected int selectionTargetIconIndex;

		protected ulong targetKeyId;

		public static TradeMaterialItemConfirmPopup Create(ShopTradeProductData.TradeShopItemData data, Action onPopupClosed)
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		protected override void Start()
		{
		}

		protected long GetMaxTradeCount()
		{
			return default(long);
		}

		protected long GetMaxCountByMaterial(int id, int needCount, GiftType giftType = GiftType.MATERIAL)
		{
			return default(long);
		}

		public void OnSliderValueChanged(float val)
		{
		}

		public void OnClosePopup(bool bOK)
		{
		}

		public void RequestItemTrade()
		{
		}

		protected void OnItemTradeSuccess(TreasureTradeTradeResponse response)
		{
		}

		protected virtual void OnTradeDone()
		{
		}

		protected void OnItemTradeSuccess(EventTradeTradeResponse response)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
