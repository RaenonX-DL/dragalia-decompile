using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopCommonItemTableViewCell : TableViewCell<ShopTradeProductData.CommonShopItemData>
	{
		[Serializable]
		public class UnityEventShopItemData : UnityEvent<ShopTradeProductData.CommonShopItemData>
		{
		}

		[SerializeField]
		public UnityEventShopItemData buttonPressed;

		[SerializeField]
		[Header("Data")]
		public Text nameText;

		public Text limitCountText;

		public Text priceText;

		public Image packIcon;

		public Text sustainableContinueTimeText;

		[SerializeField]
		[Header("OnOff")]
		public GameObject sustainableEffectiveCover;

		public GameObject quantityLimitReachedCover;

		public GameObject priceLine;

		public GameObject recommendLabel;

		public RectTransform titleRectTrans;

		[SerializeField]
		[Header("Price")]
		public GameObject crystalIcon;

		public GameObject dragonDiamondIcon;

		public GameObject goldIcon;

		public GameObject moonIcon;

		public GameObject manaIcon;

		[SerializeField]
		[Header("Button")]
		public Button button;

		[SerializeField]
		[Header("FrameContent")]
		public GameObject frameContent;

		[SerializeField]
		[Header("Caption")]
		public GameObject captionFrame;

		public Text captionText;

		[SerializeField]
		private Text periodText;

		[SerializeField]
		[Header("æ\u009c\u009fé\u0096\u0093é\u0099\u0090å®\u009aã\u0081®ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®è\u00a8­å®\u009a")]
		public float periodIconPosY;

		public float periodIconScale;

		public float periodTitlePosY;

		[SerializeField]
		[Header("æ\u009c\u009fé\u0096\u0093é\u0099\u0090å®\u009aã\u0081ªã\u0081\u0097ã\u0081®ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®è\u00a8­å®\u009a")]
		public float normalIconPosY;

		public float normalIconScale;

		public float normalTitlePosY;

		public Action onUpdateContent;

		protected ShopTradeProductData.CommonShopItemData data;

		protected ShopTradePanelBase panel;

		protected virtual void Start()
		{
		}

		public static string GetQuantityLimitText(ShopTradeProductData.CommonShopItemData.ResetType resetType, int purchaseLimit, int boughtCount)
		{
			return null;
		}

		public override void UpdateContent(ShopTradeProductData.CommonShopItemData data)
		{
		}

		public void OnPurchaseButtonPressed()
		{
		}

		private void SetPopup()
		{
		}

		private bool IsAstralItemExceed()
		{
			return default(bool);
		}

		private bool CanBuyMultiple()
		{
			return default(bool);
		}
	}
}
