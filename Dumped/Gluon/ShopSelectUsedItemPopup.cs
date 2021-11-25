using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopSelectUsedItemPopup : CommonPopup
	{
		[SerializeField]
		private Image itemIcon;

		[SerializeField]
		private Text itemNameText;

		[SerializeField]
		private Text detailText;

		[SerializeField]
		private Button crystalButton;

		[SerializeField]
		private Text crystalNumText;

		[SerializeField]
		private Text crystalHaveNumText;

		[SerializeField]
		private Button diamondButton;

		[SerializeField]
		private Text diamondNumText;

		[SerializeField]
		private Text diamondHaveNumText;

		[SerializeField]
		private Button diamondPurchaseButton;

		[SerializeField]
		private ButtonWithSelectedImage diamondPurchaseButtonSelectedImage;

		[SerializeField]
		private Text diamondPurchaseNumText;

		[SerializeField]
		private Text purcaseText;

		[SerializeField]
		private Text InsufficienText;

		private ShopTradeProductData.CommonShopItemData itemData;

		private bool hasEnoughDiamond;

		private UnityAction<PaymentType> onSelectPayMent;

		public static ShopSelectUsedItemPopup Create(ShopTradeProductData.CommonShopItemData data, [Optional] UnityAction<PaymentType> OnOkCallback)
		{
			return null;
		}

		public void SetData(ShopTradeProductData.CommonShopItemData data)
		{
		}

		public void SetContent()
		{
		}

		public override void OnCloseButtonPressed()
		{
		}

		public void OnDiamondButton()
		{
		}

		public void OnCrystalButton()
		{
		}

		public void OnPurchaseButtonPressed()
		{
		}
	}
}
