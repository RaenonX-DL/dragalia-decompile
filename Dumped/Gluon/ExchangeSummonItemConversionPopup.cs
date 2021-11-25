using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ExchangeSummonItemConversionPopup : PopupBase
	{
		[SerializeField]
		private Text summonEndtimeText;

		[SerializeField]
		private Text summonNameText;

		[SerializeField]
		private Text coversionText;

		[SerializeField]
		private CommonIcon iconA;

		[SerializeField]
		private CommonIcon iconB;

		[SerializeField]
		private Text beforeExchangePointCount;

		[SerializeField]
		private Text afterExchangePointCount;

		[SerializeField]
		private Text overSummonPointText;

		private SummonDataElement sde;

		private SummonPointDataElement spde;

		private int summonId;

		private UnityAction onExchangeEnd;

		public static ExchangeSummonItemConversionPopup Create(int summonId, int beforeExchangeItem, int getExchangeItem)
		{
			return null;
		}

		public void SetContent(int summonId, int beforeExchangeItem, int getExchangeItem)
		{
		}

		public void OnCloseExchangePopup()
		{
		}
	}
}
