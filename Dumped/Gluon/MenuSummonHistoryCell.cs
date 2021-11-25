using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuSummonHistoryCell : TableViewCell<MenuSummonHistoryCellData>
	{
		[SerializeField]
		private Text unitName;

		[SerializeField]
		private Text historyDataTime;

		public override void UpdateContent(MenuSummonHistoryCellData itemData)
		{
		}

		public void OnSummonDetailButtonClick()
		{
		}
	}
}
