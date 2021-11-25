using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ItemSentPresentBoxCell : TableViewCell<ItemSentPresentBoxCellData>
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text nameText;

		public override void UpdateContent(ItemSentPresentBoxCellData itemData)
		{
		}
	}
}
