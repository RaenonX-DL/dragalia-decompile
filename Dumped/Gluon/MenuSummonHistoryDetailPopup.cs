using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuSummonHistoryDetailPopup : PopupBase
	{
		[SerializeField]
		private Text summonName;

		[SerializeField]
		private Text summonDate;

		[SerializeField]
		private Text summonType;

		[SerializeField]
		private Text paymentType;

		[SerializeField]
		private Text unitName;

		[SerializeField]
		private Text unitRarity;

		[SerializeField]
		private Text summonDewPoint;

		[SerializeField]
		private Text summonPrize;

		[SerializeField]
		private Text summonPoint;

		public static MenuSummonHistoryDetailPopup Create(MenuSummonHistoryCellData data)
		{
			return null;
		}

		public void SetContent(MenuSummonHistoryCellData data)
		{
		}
	}
}
