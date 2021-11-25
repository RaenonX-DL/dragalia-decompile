using System;
using UnityEngine;

namespace Gluon
{
	public class ShopMultyPurchaseConfirmPopup : ShopPurchaseConfirmPopupBase
	{
		[SerializeField]
		private CommonSliderSelection buyCountSlider;

		public static ShopMultyPurchaseConfirmPopup Create(ShopTradeProductData.CommonShopItemData data, Action onPurchaseDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void RefreshPurchaseInfo(int buyCount = 1)
		{
		}

		private void RefreshSliderInfo()
		{
		}
	}
}
