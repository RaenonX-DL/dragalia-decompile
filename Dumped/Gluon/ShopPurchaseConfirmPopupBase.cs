using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopPurchaseConfirmPopupBase : PopupBase
	{
		[SerializeField]
		[Header("Top")]
		public Image packIcon;

		public Text packName;

		public Text packDescription;

		[SerializeField]
		[Header("Bottom")]
		public Text periodText;

		public Text limitCountText;

		public Text priceText;

		public Text realMoneyText;

		public Text okButtonText;

		public Button okButton;

		[SerializeField]
		[Header("Price")]
		public GameObject crystalIcon;

		public GameObject dragonDiamondIcon;

		public GameObject goldIcon;

		public GameObject moonIcon;

		public GameObject manaIcon;

		[SerializeField]
		[Header("Holding")]
		public Text beforeCountText;

		public Text afterCountText;

		public Text insufficientText;

		public Text overflowText;

		[SerializeField]
		[Header("OnOffs")]
		public GameObject periodObj;

		public GameObject resourcesGO;

		public GameObject insufficientTextGO;

		public GameObject overflowTextGO;

		protected ShopTradeProductData.CommonShopItemData data;

		protected Action onPurchaseDone;

		protected bool toPurchaseDia;

		private int buyQuantity;

		private bool isSentToPresentBox;

		public virtual void Init(ShopTradeProductData.CommonShopItemData data, Action onPurchaseDone)
		{
		}

		protected override void Start()
		{
		}

		public long GetCurrentPaymentCount(out string insufficientTemplate)
		{
			return default(long);
		}

		protected virtual void RefreshPurchaseInfo(int buyCount = 1)
		{
		}

		protected void RefreshHoldingInfo(int buyCount = 1)
		{
		}

		private bool CheckOverLimit(int buyCount)
		{
			return default(bool);
		}

		private static int CalculateAgeCorrect(int year, int month, int day)
		{
			return default(int);
		}

		public static void CheckAgeGroup(Action<ShopTradeAgeSelectPopup.AgeGroup> onCheckDone)
		{
		}

		public static ShopCommonPopup CheckUnableToPurchaseTimeForSustainablePack(ShopTradeProductData.CommonShopItemData.PackContentType packContentType)
		{
			return null;
		}

		public void OnPurchaseButtonPressed()
		{
		}

		private void ProcessPurchase(ShopTradeAgeSelectPopup.AgeGroup ageGroup = ShopTradeAgeSelectPopup.AgeGroup.None)
		{
		}

		private void ProcessCommonPurchase(Action onDone)
		{
		}

		public static void ProcessRealMoneyPurchase(string productId, ShopTradeAgeSelectPopup.AgeGroup ageGroup, ShopTradeProductData.CommonShopType shopType, int tradeId, Action onDone)
		{
		}

		public void OnSpecifiedCommercialTransactionActPressed()
		{
		}
	}
}
