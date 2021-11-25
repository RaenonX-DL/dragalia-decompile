using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectItemListCell : ItemListCell
	{
		[SerializeField]
		private Text countText;

		[SerializeField]
		private Image completeMark;

		public override void UpdateContent(ItemListCellData data)
		{
		}
	}
}
