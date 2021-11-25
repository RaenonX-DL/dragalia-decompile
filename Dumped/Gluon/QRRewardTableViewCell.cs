using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QRRewardTableViewCell : TableViewCell<QuestResultModel.FirstClearModel.FirstClearItemInfo>
	{
		public CommonIcon icon;

		public Text title;

		public Text itemName;

		[SerializeField]
		public UnityEvent<int> buttonPressed;

		public override void UpdateContent(QuestResultModel.FirstClearModel.FirstClearItemInfo data)
		{
		}

		public void OnIconLongTouched()
		{
		}
	}
}
