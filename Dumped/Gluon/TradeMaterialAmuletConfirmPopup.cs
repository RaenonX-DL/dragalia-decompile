using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TradeMaterialAmuletConfirmPopup : ShopCommonPopup
	{
		[SerializeField]
		[Header("Contents")]
		private Text confirmText;

		[SerializeField]
		private Text needDew;

		[SerializeField]
		private Text curDewText;

		[SerializeField]
		private Text afterDewText;

		[SerializeField]
		private Text errorText;

		[SerializeField]
		private Button tradeButton;

		[SerializeField]
		private ShopTableViewTradeAmuletCell amuletCell;

		private ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data;

		private bool canExchangeCrest;

		private int needDewPoint;

		private string crestName;

		public static TradeMaterialAmuletConfirmPopup Create(ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data)
		{
			return null;
		}

		private void Init(ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data)
		{
		}

		private void UpdateUI(bool canExchangeCrest)
		{
		}

		public void OnExchangeButtonTouched()
		{
		}

		private void OnItemTradeSuccess(AbilityCrestTradeTradeResponse response)
		{
		}
	}
}
