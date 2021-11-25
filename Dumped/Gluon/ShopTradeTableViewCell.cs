using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeTableViewCell : TableViewCell<ShopTradeProductData.TradeShopItemData>
	{
		public enum TradeItemType
		{
			Common,
			AbilityCrest
		}

		[Serializable]
		public class UnityEventShopItemData : UnityEvent<ShopTradeProductData.TradeShopItemData>
		{
		}

		[SerializeField]
		public UnityEventShopItemData buttonPressed;

		[SerializeField]
		[Header("Data")]
		public Text nameText;

		public Text limitCountText;

		public Text priceText;

		public Text endTimeText;

		public Text commentText;

		public CommonIcon icon;

		public bool isUseShortQuantityLimit;

		public bool hideQuantityLimitPrefix;

		[SerializeField]
		[Header("OnOff")]
		public GameObject limitCountLine;

		public GameObject timeLimitLine;

		[SerializeField]
		private List<GameObject> rarityObjs;

		[SerializeField]
		[Header("Materials")]
		public ShopTradeMaterialIcon[] materials;

		[SerializeField]
		[Header("MoonIcons")]
		public GameObject[] moonIconGOs;

		[SerializeField]
		[Header("NewFlag")]
		public GameObject newFlag;

		[SerializeField]
		[Header("Button")]
		public Button button;

		[SerializeField]
		[Header("CollectStory")]
		public GameObject needStoryBlockGO;

		public Text needStoryText;

		[SerializeField]
		private GameObject lockIconObj;

		[SerializeField]
		[Header("AbilityCrest")]
		private Sprite emptyMaterialSprite;

		[SerializeField]
		[Header("BG")]
		public RectTransform bgFrame;

		public int highQuantityLimitLayoutHeight;

		public int lowQuantityLimitLayoutHeight;

		private ShopTradePanelBase panel;

		private ShopTradeProductData.TradeShopItemData data;

		private TradeItemType type;

		private void Start()
		{
		}

		public override void UpdateContent(ShopTradeProductData.TradeShopItemData data)
		{
		}

		private ShopTradeProductData.InsufficientReason CheckSufficiencyCondition()
		{
			return default(ShopTradeProductData.InsufficientReason);
		}

		public void OnExchangeButtonPressed()
		{
		}

		private void UpdateUI()
		{
		}

		private void UpdateOKButtonForCrest(bool canExcange)
		{
		}
	}
}
