using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopEventTradeTopTableViewCell : TableViewCell<ShopTradeModel.EventTradeTopData>
	{
		[SerializeField]
		[Header("Data")]
		public Text beginTimeText;

		public Text endTimeText;

		public GameObject dateGO;

		public Text beginEndText;

		public Image banner;

		private ShopEventTradeShopTopView panel;

		private ShopTradeExchangeTopView exchangePanel;

		private ShopTradeModel.EventTradeTopData data;

		private void Start()
		{
		}

		public override void UpdateContent(ShopTradeModel.EventTradeTopData data)
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
