using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PopupIconViewCell : TableViewCell<PopupIconListData>
	{
		[SerializeField]
		public Button[] buttonArray;

		protected GrowthScene.OnGrowCharaListPress putCellCallBack;

		public GiftType giftType;

		public override void UpdateContent(PopupIconListData data)
		{
		}
	}
}
