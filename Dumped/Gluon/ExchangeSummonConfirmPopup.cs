using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ExchangeSummonConfirmPopup : PopupBase
	{
		[SerializeField]
		private Transform commonIconTrans;

		[SerializeField]
		private Text detailText;

		[SerializeField]
		private Text beforeExchangeItemCount;

		[SerializeField]
		private Text afterExchangeItemCount;

		[SerializeField]
		private Button exchangeButton;

		private SummonDataElement sde;

		private int summonId;

		private int entityId;

		private int tradeId;

		private UnityAction<int, int, int> onExchange;

		private ExchangeSummonSelectItemCellData data;

		public static ExchangeSummonConfirmPopup Create(ExchangeSummonSelectItemCellData data, UnityAction<int, int, int> onExchange)
		{
			return null;
		}

		public void SetContent(ExchangeSummonSelectItemCellData data, UnityAction<int, int, int> onExchange)
		{
		}

		public void OnExchangeButton()
		{
		}

		private void Exchange()
		{
		}

		public void Request()
		{
		}
	}
}
