using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTreasureTradeTopTableViewCell : TableViewCell<ShopTradeModel.TreasureTradeTopData>
	{
		[SerializeField]
		[Header("Data")]
		public Text beginTimeText;

		public Text endTimeText;

		public Text beginEndText;

		public Image banner;

		private ShopTreasureTradeShopTopView panel;

		private ShopTradeExchangeTopView exchangePanel;

		private ShopTradeModel.TreasureTradeTopData data;

		[SerializeField]
		private Button cellButton;

		private void Start()
		{
		}

		public override void UpdateContent(ShopTradeModel.TreasureTradeTopData data)
		{
		}

		private string CreateBannerSpritePath()
		{
			return null;
		}

		public void OnBannerPressed()
		{
		}
	}
}
