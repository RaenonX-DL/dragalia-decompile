using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ItemListCell : TableViewCell<ItemListCellData>
	{
		[SerializeField]
		private CommonIcon itemIcon;

		[SerializeField]
		private GameObject captionBase;

		[SerializeField]
		private Text captionText;

		[SerializeField]
		private GameObject fundsBase;

		[SerializeField]
		private Text rupyText;

		[SerializeField]
		private Text manaText;

		[SerializeField]
		private Text dewText;

		[SerializeField]
		private Text messageText;

		private ItemListCellData cellData;

		public override void UpdateContent(ItemListCellData data)
		{
		}

		public void OnIconButtonPressed()
		{
		}
	}
}
