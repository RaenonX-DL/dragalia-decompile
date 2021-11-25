using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExcludeSummonConfirmCell : TableViewCell<ExcludeSummonConfirmCellData>
	{
		[SerializeField]
		private Transform unitIconTrans;

		[SerializeField]
		private Text unitNameText;

		public override void UpdateContent(ExcludeSummonConfirmCellData itemData)
		{
		}
	}
}
