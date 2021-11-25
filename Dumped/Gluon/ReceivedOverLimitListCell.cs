using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ReceivedOverLimitListCell : TableViewCell<ReceivedOverLimitListCellData>
	{
		[SerializeField]
		private Text itemNameText;

		[SerializeField]
		private Text quantityText;

		public override void UpdateContent(ReceivedOverLimitListCellData data)
		{
		}
	}
}
