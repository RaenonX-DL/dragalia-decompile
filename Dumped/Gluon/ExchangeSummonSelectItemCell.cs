using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExchangeSummonSelectItemCell : TableViewCell<ExchangeSummonSelectItemCellData>
	{
		[SerializeField]
		private Text charaName;

		[SerializeField]
		private GameObject colleague;

		[SerializeField]
		private Transform charaIconTrans;

		[SerializeField]
		private Button summonButton;

		[SerializeField]
		private Text countText;

		public Action<ExchangeSummonSelectItemCellData> onSummonButtonClick;

		private ExchangeSummonSelectItemCellData data;

		public override void UpdateContent(ExchangeSummonSelectItemCellData itemData)
		{
		}

		public void OnSummonButtonClick()
		{
		}
	}
}
