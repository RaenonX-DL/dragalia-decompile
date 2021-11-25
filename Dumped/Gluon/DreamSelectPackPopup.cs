using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DreamSelectPackPopup : PopupBase
	{
		public const string path = "Prefabs/OutGame/ShopTrade/Popup/DreamSelectPackPopup";

		[SerializeField]
		private RawImage bgImage;

		[SerializeField]
		private Text limitCountText;

		[SerializeField]
		private Text priceText;

		[SerializeField]
		private Text periodText;

		private ShopTradeProductData.CommonShopItemData itemData;

		private const string imagePathTemplate = "Images/OutGame/Shop/Top/DreamSelect/{0}";

		public void Init(ShopTradeProductData.CommonShopItemData itemData)
		{
		}

		public void OnPurchaseButtonClicked()
		{
		}
	}
}
